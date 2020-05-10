using Newtonsoft.Json;
using PlaytestDocumenter.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PlaytestDocumenter.ViewModel
{
    class MainViewModel
    {
        public List<string> Templates { get; set; } = new List<string>();

        public MainViewModel()
        {
            refreshTemplates();

            CommandRefreshTemplates = new RelayCommand(refreshTemplates);
        }

        public void refreshTemplates()
        {
            Templates.Clear();
            foreach (string path in Directory.GetFiles("templates")) {

                try
                {
                    Template t = JsonConvert.DeserializeObject<Template>(System.IO.File.ReadAllText(path));
                    if(t != null)
                        Templates.Add($"{t.GameName} | {t.Version}");
                } catch(Exception e)
                {
                    // TODO: Log this error
                }
                
            }

            

        }

        public ICommand CommandRefreshTemplates;
    }
}
