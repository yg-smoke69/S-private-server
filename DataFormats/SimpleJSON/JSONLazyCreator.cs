using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FF9")]
internal class JSONLazyCreator : JSONNode
{
	[Token(Token = "0x401AEBC")]
	[FieldOffset(Offset = "0x8")]
	private JSONNode m_Node;

	[Token(Token = "0x401AEBD")]
	[FieldOffset(Offset = "0xC")]
	private string m_Key;

	[Token(Token = "0x17001CA0")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x601A0F3")]
		[Address(RVA = "0x21C8714", Offset = "0x21C8714", VA = "0x21C8714", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17001CA1")]
	public override JSONNode Item
	{
		[Token(Token = "0x601A0F6")]
		[Address(RVA = "0x21C87BC", Offset = "0x21C87BC", VA = "0x21C87BC", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0F7")]
		[Address(RVA = "0x21C882C", Offset = "0x21C882C", VA = "0x21C882C", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17001CA2")]
	public override JSONNode Item
	{
		[Token(Token = "0x601A0F8")]
		[Address(RVA = "0x21C88CC", Offset = "0x21C88CC", VA = "0x21C88CC", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0F9")]
		[Address(RVA = "0x21C8944", Offset = "0x21C8944", VA = "0x21C8944", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17001CA3")]
	public override int AsInt
	{
		[Token(Token = "0x601A100")]
		[Address(RVA = "0x21C8C50", Offset = "0x21C8C50", VA = "0x21C8C50", Slot = "31")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601A101")]
		[Address(RVA = "0x21C8D74", Offset = "0x21C8D74", VA = "0x21C8D74", Slot = "32")]
		set
		{
		}
	}

	[Token(Token = "0x17001CA4")]
	public override float AsFloat
	{
		[Token(Token = "0x601A102")]
		[Address(RVA = "0x21C8E00", Offset = "0x21C8E00", VA = "0x21C8E00", Slot = "33")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601A103")]
		[Address(RVA = "0x21C8E88", Offset = "0x21C8E88", VA = "0x21C8E88", Slot = "34")]
		set
		{
		}
	}

	[Token(Token = "0x17001CA5")]
	public override double AsDouble
	{
		[Token(Token = "0x601A104")]
		[Address(RVA = "0x21C8F18", Offset = "0x21C8F18", VA = "0x21C8F18", Slot = "29")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x601A105")]
		[Address(RVA = "0x21C8FAC", Offset = "0x21C8FAC", VA = "0x21C8FAC", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x17001CA6")]
	public override bool AsBool
	{
		[Token(Token = "0x601A106")]
		[Address(RVA = "0x21C9038", Offset = "0x21C9038", VA = "0x21C9038", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A107")]
		[Address(RVA = "0x21C90B4", Offset = "0x21C90B4", VA = "0x21C90B4", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x17001CA7")]
	public override JSONArray AsArray
	{
		[Token(Token = "0x601A108")]
		[Address(RVA = "0x21C9130", Offset = "0x21C9130", VA = "0x21C9130", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CA8")]
	public override JSONObject AsObject
	{
		[Token(Token = "0x601A109")]
		[Address(RVA = "0x21C91A8", Offset = "0x21C91A8", VA = "0x21C91A8", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A0F1")]
	[Address(RVA = "0x21C7414", Offset = "0x21C7414", VA = "0x21C7414")]
	public JSONLazyCreator(JSONNode aNode)
	{
	}

	[Token(Token = "0x601A0F2")]
	[Address(RVA = "0x21C8680", Offset = "0x21C8680", VA = "0x21C8680")]
	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
	}

	[Token(Token = "0x601A0F4")]
	[Address(RVA = "0x21C871C", Offset = "0x21C871C", VA = "0x21C871C", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x601A0F5")]
	[Address(RVA = "0x21C8738", Offset = "0x21C8738", VA = "0x21C8738")]
	private void Set(JSONNode aVal)
	{
	}

	[Token(Token = "0x601A0FA")]
	[Address(RVA = "0x21C8AA4", Offset = "0x21C8AA4", VA = "0x21C8AA4", Slot = "21")]
	public override void Add(JSONNode aItem)
	{
	}

	[Token(Token = "0x601A0FB")]
	[Address(RVA = "0x21C8B44", Offset = "0x21C8B44", VA = "0x21C8B44", Slot = "20")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x601A0FC")]
	[Address(RVA = "0x21C8BEC", Offset = "0x21C8BEC", VA = "0x21C8BEC")]
	public static bool operator ==(JSONLazyCreator a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0FD")]
	[Address(RVA = "0x21C8C0C", Offset = "0x21C8C0C", VA = "0x21C8C0C")]
	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0FE")]
	[Address(RVA = "0x21C8C28", Offset = "0x21C8C28", VA = "0x21C8C28", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601A0FF")]
	[Address(RVA = "0x21C8C48", Offset = "0x21C8C48", VA = "0x21C8C48", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x601A10A")]
	[Address(RVA = "0x21C9220", Offset = "0x21C9220", VA = "0x21C9220", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
