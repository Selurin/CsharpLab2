using System;

internal class Name
{
    private string? familia;
    private string? imya;
    private string? otchestvo;

    public Name(string? familia = null, string? imya = null, string? otchestvo = null)
    {

        this.familia = familia;
        this.imya = imya;
        this.otchestvo = otchestvo;
    }

    public string? Familia
    {
        get { return this.familia; }
        set { this.familia = value; }
    }

    public override string ToString()
    {
        string vp = "";

        if (!string.IsNullOrEmpty(familia))
        {
            vp += familia.Trim();
            if (!string.IsNullOrEmpty(imya) || !string.IsNullOrEmpty(otchestvo))
            {
                vp += " ";
            }
        }

        if (!string.IsNullOrEmpty(imya))
        {
            vp += imya.Trim();
            if (!string.IsNullOrEmpty(otchestvo))
            {
                vp += " ";
            }
        }

        if (!string.IsNullOrEmpty(otchestvo))
        {
            vp += otchestvo.Trim();
        }

        return vp;
    }
}