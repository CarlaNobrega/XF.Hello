using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigPage : ContentPage
	{
		public ConfigPage ()
		{
            //Configuracao configuracao = InitConfiguracao(true, false, true, false, true);
            BindingContext = App.ConfigModel;
			InitializeComponent ();
		}

        private Configuracao InitConfiguracao(bool rastrearLocalizacao, bool permitirCookies, bool disponibilizarMural, bool EnviarEmail, bool receberSMS)
        {
            return new Configuracao
            {
                RastrearLocalizacao = rastrearLocalizacao,
                PermitirCookies = permitirCookies,
                DisponibilizarMural = disponibilizarMural,
                EnviarEmail = EnviarEmail,
                ReceberSMS = receberSMS
            };
            
        }
    }
}