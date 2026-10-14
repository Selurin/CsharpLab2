using System;

internal class Name
{
	private string familia;
	private string imya;
	private string otchestvo;

	public Name(string familia = null, string imya = null, string otchestvo = null)
	{

		this.familia = familia ?? "Ivanov";
		this.imya = imya ?? "Ivan";
		this.otchestvo = otchestvo ?? "Ivanovich";
	}

	public string Familia
	{
		get { return this.familia; }
		set
		{this.familia = value;}
	}

    public override string ToString()
    {
        return $"{familia} {imya} {otchestvo}";
    }
}