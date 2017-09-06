﻿using System.Xml;
using FatturaElettronica.Common;

namespace ComunicazioneFattureCorrispettivi.Common
{
    public class CedenteCessionario : BaseClassSerializable
    {
        private readonly IdentificativiFiscali _identificativiFiscali;
        private readonly AltriDatiIdentificativi _altriDatiIdentificativi;

        public CedenteCessionario()
        {
            _identificativiFiscali = new IdentificativiFiscali();
            _altriDatiIdentificativi = new AltriDatiIdentificativi();
        }
        public CedenteCessionario(XmlReader r) : base(r) { }

        [DataProperty]
        public IdentificativiFiscali IdentificativiFiscali => _identificativiFiscali;
        [DataProperty]
        public AltriDatiIdentificativi AltriDatiIdentificativi => _altriDatiIdentificativi;
    }
}