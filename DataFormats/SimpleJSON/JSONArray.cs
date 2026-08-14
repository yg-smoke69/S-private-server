using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FF0")]
public class JSONArray : JSONNode
{
	[Token(Token = "0x2003FF1")]
	private sealed class _003C_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x401AEA8")]
		[FieldOffset(Offset = "0x8")]
		internal List<JSONNode>.Enumerator _0024locvar0;

		[Token(Token = "0x401AEA9")]
		[FieldOffset(Offset = "0x18")]
		internal JSONNode _003CN_003E__1;

		[Token(Token = "0x401AEAA")]
		[FieldOffset(Offset = "0x1C")]
		internal JSONArray _0024this;

		[Token(Token = "0x401AEAB")]
		[FieldOffset(Offset = "0x20")]
		internal JSONNode _0024current;

		[Token(Token = "0x401AEAC")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x401AEAD")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001C86")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x601A0A1")]
			[Address(RVA = "0x21C8168", Offset = "0x21C8168", VA = "0x21C8168", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C87")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A0A2")]
			[Address(RVA = "0x21C8170", Offset = "0x21C8170", VA = "0x21C8170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A09F")]
		[Address(RVA = "0x21C7D60", Offset = "0x21C7D60", VA = "0x21C7D60")]
		public _003C_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601A0A0")]
		[Address(RVA = "0x21C7FB0", Offset = "0x21C7FB0", VA = "0x21C7FB0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A0A3")]
		[Address(RVA = "0x21C8178", Offset = "0x21C8178", VA = "0x21C8178", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A0A4")]
		[Address(RVA = "0x21C81F8", Offset = "0x21C81F8", VA = "0x21C81F8", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x601A0A5")]
		[Address(RVA = "0x21C8280", Offset = "0x21C8280", VA = "0x21C8280", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x601A0A6")]
		[Address(RVA = "0x21C8284", Offset = "0x21C8284", VA = "0x21C8284", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x401AEA6")]
	[FieldOffset(Offset = "0x8")]
	private List<JSONNode> m_List;

	[Token(Token = "0x401AEA7")]
	[FieldOffset(Offset = "0xC")]
	private bool inline;

	[Token(Token = "0x17001C7F")]
	public override bool Inline
	{
		[Token(Token = "0x601A090")]
		[Address(RVA = "0x21C7220", Offset = "0x21C7220", VA = "0x21C7220", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A091")]
		[Address(RVA = "0x21C7228", Offset = "0x21C7228", VA = "0x21C7228", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17001C80")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x601A092")]
		[Address(RVA = "0x21C7230", Offset = "0x21C7230", VA = "0x21C7230", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17001C81")]
	public override bool IsArray
	{
		[Token(Token = "0x601A093")]
		[Address(RVA = "0x21C7238", Offset = "0x21C7238", VA = "0x21C7238", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C82")]
	public override JSONNode Item
	{
		[Token(Token = "0x601A095")]
		[Address(RVA = "0x21C732C", Offset = "0x21C732C", VA = "0x21C732C", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A096")]
		[Address(RVA = "0x21C74A8", Offset = "0x21C74A8", VA = "0x21C74A8", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17001C83")]
	public override JSONNode Item
	{
		[Token(Token = "0x601A097")]
		[Address(RVA = "0x21C7874", Offset = "0x21C7874", VA = "0x21C7874", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A098")]
		[Address(RVA = "0x21C78E4", Offset = "0x21C78E4", VA = "0x21C78E4", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17001C84")]
	public override int Count
	{
		[Token(Token = "0x601A099")]
		[Address(RVA = "0x21C79D8", Offset = "0x21C79D8", VA = "0x21C79D8", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C85")]
	public override IEnumerable<JSONNode> Children
	{
		[Token(Token = "0x601A09D")]
		[Address(RVA = "0x21C7CC0", Offset = "0x21C7CC0", VA = "0x21C7CC0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A08F")]
	[Address(RVA = "0x21C7160", Offset = "0x21C7160", VA = "0x21C7160")]
	public JSONArray()
	{
	}

	[Token(Token = "0x601A094")]
	[Address(RVA = "0x21C7240", Offset = "0x21C7240", VA = "0x21C7240", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x601A09A")]
	[Address(RVA = "0x21C7A50", Offset = "0x21C7A50", VA = "0x21C7A50", Slot = "20")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x601A09B")]
	[Address(RVA = "0x21C7B44", Offset = "0x21C7B44", VA = "0x21C7B44", Slot = "23")]
	public override JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x601A09C")]
	[Address(RVA = "0x21C7C3C", Offset = "0x21C7C3C", VA = "0x21C7C3C", Slot = "24")]
	public override JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x601A09E")]
	[Address(RVA = "0x21C7D68", Offset = "0x21C7D68", VA = "0x21C7D68", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
