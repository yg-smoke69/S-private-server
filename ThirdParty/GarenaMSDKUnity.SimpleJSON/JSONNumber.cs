using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000025")]
public class JSONNumber : JSONNode
{
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x8")]
	private double m_Data;

	[Token(Token = "0x17000042")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x3500354", Offset = "0x3500354", VA = "0x3500354", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17000043")]
	public override bool IsNumber
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x350035C", Offset = "0x350035C", VA = "0x350035C", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000044")]
	public override string Value
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x3500380", Offset = "0x3500380", VA = "0x3500380", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x350038C", Offset = "0x350038C", VA = "0x350038C", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public override double AsDouble
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x35003D0", Offset = "0x35003D0", VA = "0x35003D0", Slot = "29")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x35003DC", Offset = "0x35003DC", VA = "0x35003DC", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x3500218", Offset = "0x3500218", VA = "0x3500218")]
	public JSONNumber(double aData)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x35002B4", Offset = "0x35002B4", VA = "0x35002B4")]
	public JSONNumber(string aData)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x3500364", Offset = "0x3500364", VA = "0x3500364", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x35003EC", Offset = "0x35003EC", VA = "0x35003EC", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x3500434", Offset = "0x3500434", VA = "0x3500434")]
	private static bool IsNumeric(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x3500590", Offset = "0x3500590", VA = "0x3500590", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x3500724", Offset = "0x3500724", VA = "0x3500724", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
