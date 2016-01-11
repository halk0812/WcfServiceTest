using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WcfServiceInterface;

namespace databaseCreate
{
    public partial class MyClient : Form
    {
        public MyClient()
        {
            InitializeComponent();
        }

        private void _sendButton_Click(object sender, EventArgs e)
        {
            try {
                BasicHttpBinding _myBinding = new BasicHttpBinding();
                EndpointAddress _myEndpoint = new EndpointAddress(_adressTextBox.Text);
                ChannelFactory<IMyService> _myChannelFactory = new ChannelFactory<IMyService>(_myBinding, _myEndpoint);
                IMyService _myService = _myChannelFactory.CreateChannel();
                TypeEvent _typeEvent;
                Enum.TryParse((_bsTypeEvent.Current as string), out _typeEvent);
                LevelImportance _level;
                Enum.TryParse((_bsLevelImportance.Current as string), out _level);

                string res = _myService.SendMessage(new WcfServiceInterface.Message()
                {
                    _events= _typeEvent,
                    _level= _level,
                    _message=_textBoxMessage.Text
                });
                MessageBox.Show(res);
            }
            catch(Exception _exc)
            {
                MessageBox.Show(_exc.Message);
            }
        }

        List<string> GetListStringFromEnum(Type _typeEnum)
        {
            List<string> _strinNameEnum = new List<string>();
            foreach (var item in Enum.GetValues(_typeEnum))
            {
                _strinNameEnum.Add( item.ToString());
                               
            }
            return _strinNameEnum;
        }

        private void MyClient_Load(object sender, EventArgs e)
        {
            
            _bsLevelImportance.DataSource = GetListStringFromEnum(typeof(LevelImportance));
            _bsTypeEvent.DataSource = GetListStringFromEnum(typeof(TypeEvent));
            _bsLevelImportance.ResetBindings(false);
            _bsTypeEvent.ResetBindings(false);
        }
    }
}
