using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Affaires
{
    public class InscriptionGolf
    {
        private int _coupsNormalTrou;
        private int _nbCoups;
        public int CoupsNormalTrou
        {
            get { return _coupsNormalTrou; }
            set { _coupsNormalTrou = value; }
        }

        public int NbCoups
        {
            get { return _nbCoups; }
            set { _nbCoups = value; }
        }

        public InscriptionGolf(int coupsNormalTrou)
        {
            _coupsNormalTrou = coupsNormalTrou;
            _nbCoups = 0;
        }
        public void frapperBalle()
        {
            _nbCoups += 1;
        }
        public void frapperCoupPerdu()
        {
            _nbCoups += 2;
        }
        public string determinerTermePointage()
        {
            string TermeFrancais;
            if (_nbCoups - _coupsNormalTrou == -2)
                TermeFrancais = "Aigle";
            else
                if (_nbCoups - _coupsNormalTrou == -1)
                TermeFrancais = "Oiselet";
            else
                if (_nbCoups - _coupsNormalTrou == 0)
                TermeFrancais = "Normal";
            else
                if (_nbCoups - _coupsNormalTrou == 1)
                TermeFrancais = "Bogey";
            else
                if (_nbCoups - _coupsNormalTrou == 2)
                TermeFrancais = "Double bogey";
            else
                if (_nbCoups - _coupsNormalTrou == 3)
                TermeFrancais = "Triple bogey";
            else
                TermeFrancais = "";
            return TermeFrancais;
        }
    }
}

