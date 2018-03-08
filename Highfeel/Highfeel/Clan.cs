using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highfeel
{
    class Clan
    {
        private int _clanId;
        private string _clanName;
        private int _clanAdmin;

        #region get-set
        public int ClanId { get => _clanId; set => _clanId = value; }
        public string ClanName { get => _clanName; set => _clanName = value; }
        public int ClanAdmin { get => _clanAdmin; set => _clanAdmin = value; }
        #endregion

        public Clan()
        {

        }

        public Clan(int clanId)
        {
            this.ClanId = clanId;
        }

        public Clan(string name)
        {
            this.ClanName = name;
        }

        public Clan(int clanId, string name, int clanAdmin)
        {
            this.ClanId = clanId;
            this.ClanName = name;
            this.ClanAdmin = clanAdmin;
        }
    }
}
