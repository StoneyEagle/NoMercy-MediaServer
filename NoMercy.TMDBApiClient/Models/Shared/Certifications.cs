using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class Certification
{
    [JsonProperty("certifications")] public CertificationList Certifications { get; set; } = new CertificationList();

    public List<CertificationItem> ToArray()
    {
        var certifications = new List<CertificationItem>();

        var index = 0;
        while (index < Certifications.Au.Length)
        {
            var y = Certifications.Au[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "AU"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Bg.Length)
        {
            var y = Certifications.Bg[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "BG"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Br.Length)
        {
            var y = Certifications.Br[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "BR"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Caqc?.Length)
        {
            var y = Certifications.Caqc[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "CAQC"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Ca.Length)
        {
            var y = Certifications.Ca[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "CA"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.De.Length)
        {
            var y = Certifications.De[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "DE"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Dk.Length)
        {
            var y = Certifications.Dk[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "DK"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Es.Length)
        {
            var y = Certifications.Es[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "ES"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Fi.Length)
        {
            var y = Certifications.Fi[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "FI"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Fr.Length)
        {
            var y = Certifications.Fr[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "FR"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Gb.Length)
        {
            var y = Certifications.Gb[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "GB"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Hu.Length)
        {
            var y = Certifications.Hu[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "HU"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.In.Length)
        {
            var y = Certifications.In[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "IN"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.It.Length)
        {
            var y = Certifications.It[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "IT"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Kr.Length)
        {
            var y = Certifications.Kr[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "KR"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Lt.Length)
        {
            var y = Certifications.Lt[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "LT"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.My.Length)
        {
            var y = Certifications.My[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "MY"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Nl.Length)
        {
            var y = Certifications.Nl[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "NL"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.No.Length)
        {
            var y = Certifications.No[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "NO"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Nz.Length)
        {
            var y = Certifications.Nz[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "NZ"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Ph.Length)
        {
            var y = Certifications.Ph[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "PH"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Pt.Length)
        {
            var y = Certifications.Pt[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "PT"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Ru.Length)
        {
            var y = Certifications.Ru[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "RU"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Se.Length)
        {
            var y = Certifications.Se[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "SE"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Sk.Length)
        {
            var y = Certifications.Sk[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "SK"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Th.Length)
        {
            var y = Certifications.Th[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "TH"
            });
            index += 1;
        }

        index = 0;
        while (index < Certifications.Us.Length)
        {
            var y = Certifications.Us[index];
            certifications.Add(new CertificationItem
            {
                Certification = y.Certification,
                Meaning = y.Meaning,
                Order = y.Order,
                Iso31661 = "US"
            });
            index += 1;
        }

        return certifications;
    }
}

public class CertificationList
{
    [JsonProperty("AU")] public CertificationItem[] Au { get; set; } = new CertificationItem[0];

    [JsonProperty("BG")] public CertificationItem[] Bg { get; set; } = new CertificationItem[0];

    [JsonProperty("BR")] public CertificationItem[] Br { get; set; } = new CertificationItem[0];

    [JsonProperty("CA-QC")] public CertificationItem[] Caqc { get; set; } = new CertificationItem[0];

    [JsonProperty("CA")] public CertificationItem[] Ca { get; set; } = new CertificationItem[0];

    [JsonProperty("DE")] public CertificationItem[] De { get; set; } = new CertificationItem[0];

    [JsonProperty("ES")] public CertificationItem[] Es { get; set; } = new CertificationItem[0];

    [JsonProperty("FI")] public CertificationItem[] Fi { get; set; } = new CertificationItem[0];

    [JsonProperty("FR")] public CertificationItem[] Fr { get; set; } = new CertificationItem[0];

    [JsonProperty("GB")] public CertificationItem[] Gb { get; set; } = new CertificationItem[0];

    [JsonProperty("HU")] public CertificationItem[] Hu { get; set; } = new CertificationItem[0];

    [JsonProperty("IN")] public CertificationItem[] In { get; set; } = new CertificationItem[0];

    [JsonProperty("KR")] public CertificationItem[] Kr { get; set; } = new CertificationItem[0];

    [JsonProperty("LT")] public CertificationItem[] Lt { get; set; } = new CertificationItem[0];

    [JsonProperty("NL")] public CertificationItem[] Nl { get; set; } = new CertificationItem[0];

    [JsonProperty("NZ")] public CertificationItem[] Nz { get; set; } = new CertificationItem[0];

    [JsonProperty("PH")] public CertificationItem[] Ph { get; set; } = new CertificationItem[0];

    [JsonProperty("RU")] public CertificationItem[] Ru { get; set; } = new CertificationItem[0];

    [JsonProperty("SK")] public CertificationItem[] Sk { get; set; } = new CertificationItem[0];

    [JsonProperty("US")] public CertificationItem[] Us { get; set; } = new CertificationItem[0];

    [JsonProperty("DK")] public CertificationItem[] Dk { get; set; } = new CertificationItem[0];

    [JsonProperty("IT")] public CertificationItem[] It { get; set; } = new CertificationItem[0];

    [JsonProperty("MY")] public CertificationItem[] My { get; set; } = new CertificationItem[0];

    [JsonProperty("NO")] public CertificationItem[] No { get; set; } = new CertificationItem[0];

    [JsonProperty("SE")] public CertificationItem[] Se { get; set; } = new CertificationItem[0];

    [JsonProperty("TH")] public CertificationItem[] Th { get; set; } = new CertificationItem[0];

    [JsonProperty("PT")] public CertificationItem[] Pt { get; set; } = new CertificationItem[0];
}

public class CertificationItem
{
    [JsonProperty("certification")] public string Certification { get; set; } = string.Empty;

    [JsonProperty("meaning")] public string Meaning { get; set; } = string.Empty;

    [JsonProperty("order")] public int Order { get; set; }

    public string Iso31661 { get; set; } = string.Empty;
}