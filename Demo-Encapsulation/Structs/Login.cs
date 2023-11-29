using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Encapsulation.Structs
{
    public struct Login
    {
        #region Champs
        private string _password;

        #endregion

        #region Propriétés
        public string Email { get; set; }      //Auto-propriété : Pas besoin de variable, pas de contrôle sur son contenu
        public string Password                 //propriété simple : Besoin d'une variable, définir le contenu de get et set
        {
            private get { return _password; }  //get :
                                               // permet la récupération de valeur, donc besoin d'un return
            set {                              //set :
                value = value.Trim();
                if(value.Length >=8 && value.Length <=16) { 
                    _password = value;
                }
            }         
                                               // permet la sauvegarde de valeur, celle-ci est définie par value
                                               // qui est comme un paramètre d'une méthode
        }
        #endregion

        #region Constructeurs

        #endregion

        #region Methodes
        public void ChangePassword(string password) {
            Password = password;
        }

        public bool SeConnecter()
        {
            return Password == "Test1234=" && Email=="samuel.legrain@bstorm.be";
        }
        #endregion
    }
}
