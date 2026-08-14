using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000026")]
public class JSONBool : JSONNode
{
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x8")]
	private bool m_Data;

	[Token(Token = "0x17000046")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x346ACA8", Offset = "0x346ACA8", VA = "0x346ACA8", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17000047")]
	public override bool IsBoolean
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x346ACB0", Offset = "0x346ACB0", VA = "0x346ACB0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000048")]
	public override string Value
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x346ACD4", Offset = "0x346ACD4", VA = "0x346ACD4", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x346ACE0", Offset = "0x346ACE0", VA = "0x346ACE0", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public override bool AsBool
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x346AD88", Offset = "0x346AD88", VA = "0x346AD88", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x346AD90", Offset = "0x346AD90", VA = "0x346AD90", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x346AB7C", Offset = "0x346AB7C", VA = "0x346AB7C")]
	public JSONBool(bool aData)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x346AC08", Offset = "0x346AC08", VA = "0x346AC08")]
	public JSONBool(string aData)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x346ACB8", Offset = "0x346ACB8", VA = "0x346ACB8", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x346AD98", Offset = "0x346AD98", VA = "0x346AD98", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x346AE2C", Offset = "0x346AE2C", VA = "0x346AE2C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x346AEC0", Offset = "0x346AEC0", VA = "0x346AEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
