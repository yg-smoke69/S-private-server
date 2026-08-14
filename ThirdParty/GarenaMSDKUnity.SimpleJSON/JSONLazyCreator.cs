using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000028")]
internal class JSONLazyCreator : JSONNode
{
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x8")]
	private JSONNode m_Node;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0xC")]
	private string m_Key;

	[Token(Token = "0x1700004E")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x346AF60", Offset = "0x346AF60", VA = "0x346AF60", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x1700004F")]
	public override JSONNode Item
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x346B008", Offset = "0x346B008", VA = "0x346B008", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x346B078", Offset = "0x346B078", VA = "0x346B078", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public override JSONNode Item
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x346B118", Offset = "0x346B118", VA = "0x346B118", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x346B190", Offset = "0x346B190", VA = "0x346B190", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public override int AsInt
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x346B3EC", Offset = "0x346B3EC", VA = "0x346B3EC", Slot = "31")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x346B480", Offset = "0x346B480", VA = "0x346B480", Slot = "32")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public override float AsFloat
	{
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x346B518", Offset = "0x346B518", VA = "0x346B518", Slot = "33")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x346B5AC", Offset = "0x346B5AC", VA = "0x346B5AC", Slot = "34")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public override double AsDouble
	{
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x346B648", Offset = "0x346B648", VA = "0x346B648", Slot = "29")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x346B6E8", Offset = "0x346B6E8", VA = "0x346B6E8", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public override bool AsBool
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x346B780", Offset = "0x346B780", VA = "0x346B780", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x346B7FC", Offset = "0x346B7FC", VA = "0x346B7FC", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public override JSONArray AsArray
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x346B878", Offset = "0x346B878", VA = "0x346B878", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000056")]
	public override JSONObject AsObject
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x346B8F0", Offset = "0x346B8F0", VA = "0x346B8F0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x3469D30", Offset = "0x3469D30", VA = "0x3469D30")]
	public JSONLazyCreator(JSONNode aNode)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x346AECC", Offset = "0x346AECC", VA = "0x346AECC")]
	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x346AF68", Offset = "0x346AF68", VA = "0x346AF68", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x346AF84", Offset = "0x346AF84", VA = "0x346AF84")]
	private void Set(JSONNode aVal)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x346B23C", Offset = "0x346B23C", VA = "0x346B23C", Slot = "21")]
	public override void Add(JSONNode aItem)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x346B2DC", Offset = "0x346B2DC", VA = "0x346B2DC", Slot = "20")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x346B388", Offset = "0x346B388", VA = "0x346B388")]
	public static bool operator ==(JSONLazyCreator a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x346B3A8", Offset = "0x346B3A8", VA = "0x346B3A8")]
	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x346B3C4", Offset = "0x346B3C4", VA = "0x346B3C4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x346B3E4", Offset = "0x346B3E4", VA = "0x346B3E4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x346B96C", Offset = "0x346B96C", VA = "0x346B96C", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
