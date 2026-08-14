using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000024")]
public class JSONString : JSONNode
{
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x8")]
	private string m_Data;

	[Token(Token = "0x1700003F")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x3501E78", Offset = "0x3501E78", VA = "0x3501E78", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17000040")]
	public override bool IsString
	{
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x3501E80", Offset = "0x3501E80", VA = "0x3501E80", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000041")]
	public override string Value
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x3501EA4", Offset = "0x3501EA4", VA = "0x3501EA4", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x3501EAC", Offset = "0x3501EAC", VA = "0x3501EAC", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x3501DEC", Offset = "0x3501DEC", VA = "0x3501DEC")]
	public JSONString(string aData)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x3501E88", Offset = "0x3501E88", VA = "0x3501E88", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x3501EB4", Offset = "0x3501EB4", VA = "0x3501EB4", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x3501FAC", Offset = "0x3501FAC", VA = "0x3501FAC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x3502148", Offset = "0x3502148", VA = "0x3502148", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
