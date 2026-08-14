using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C21")]
public struct HsvColor
{
	[Token(Token = "0x4006476")]
	[FieldOffset(Offset = "0x0")]
	public double H;

	[Token(Token = "0x4006477")]
	[FieldOffset(Offset = "0x8")]
	public double S;

	[Token(Token = "0x4006478")]
	[FieldOffset(Offset = "0x10")]
	public double V;

	[Token(Token = "0x170007E8")]
	public float normalizedH
	{
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x93BC60", Offset = "0x93BC60", VA = "0x93BC60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0x93BC68", Offset = "0x93BC68", VA = "0x93BC68")]
		set
		{
		}
	}

	[Token(Token = "0x170007E9")]
	public float normalizedS
	{
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0x93BC70", Offset = "0x93BC70", VA = "0x93BC70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0x93BC78", Offset = "0x93BC78", VA = "0x93BC78")]
		set
		{
		}
	}

	[Token(Token = "0x170007EA")]
	public float normalizedV
	{
		[Token(Token = "0x6005CB6")]
		[Address(RVA = "0x93BC80", Offset = "0x93BC80", VA = "0x93BC80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6005CB7")]
		[Address(RVA = "0x93BC88", Offset = "0x93BC88", VA = "0x93BC88")]
		set
		{
		}
	}

	[Token(Token = "0x6005CB1")]
	[Address(RVA = "0x93BC40", Offset = "0x93BC40", VA = "0x93BC40")]
	public HsvColor(double h, double s, double v)
	{
	}

	[Token(Token = "0x6005CB8")]
	[Address(RVA = "0x93BC90", Offset = "0x93BC90", VA = "0x93BC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005CB9")]
	[Address(RVA = "0x93BC98", Offset = "0x93BC98", VA = "0x93BC98")]
	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
