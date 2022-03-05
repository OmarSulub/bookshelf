using System;
using System.Collections.Generic;

namespace TipsMaskinen1
{
    // Basklass
    public class Bok
    {
        // Egenskap
        public string titel;
        public string forfattare;
        public string typ;
        public bool tillgänglig;
        // metod
        public Bok(string titel, string forfattare, string typ, bool tillgänglig)
        {
            this.titel = titel;
            this.forfattare = forfattare;
            this.typ = typ;
            this.tillgänglig = tillgänglig;
        }
    }
    // underklass
    public class Novell : Bok
    {
        public Novell(string titel, string forfattare, bool tillgänglig)
            : base(titel, forfattare, "Novell", tillgänglig)
        {
        }
        public override string ToString()
        {
            return "\"" + titel + "\" av " + forfattare + ". (" + typ + ")";
        }// underklassens tostring metod.
    }
    // Underklass
    public class Roman : Bok
    {
        public Roman(string titel, string forfattare, bool tillgänglig)
            : base(titel, forfattare, "Roman", tillgänglig)
        {
        }
        public override string ToString()
        {
            return "\"" + titel + "\" av " + forfattare + ". (" + typ + ")";
        }// underklassens tostring metod.
    }
    // Underklass
    public class Tidsskrift : Bok
    {
        public Tidsskrift(string titel, string forfattare, bool tillgänglig)
            : base(titel, forfattare, "Tidsskrift", tillgänglig)
        {
        }
        public override string ToString()
        {
            return "\"" + titel + "\" av " + forfattare + ". (" + typ + ")";
        }// underklassens tostring metod.
    }
}
