using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FF2")]
public class JSONObject : JSONNode
{
	[Token(Token = "0x2003FF3")]
	private sealed class _003CRemove_003Ec__AnonStorey1
	{
		[Token(Token = "0x401AEB0")]
		[FieldOffset(Offset = "0x8")]
		internal JSONNode aNode;

		[Token(Token = "0x601A0B8")]
		[Address(RVA = "0x21CD4B4", Offset = "0x21CD4B4", VA = "0x21CD4B4")]
		public _003CRemove_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601A0B9")]
		[Address(RVA = "0x21CDD8C", Offset = "0x21CDD8C", VA = "0x21CDD8C")]
		internal bool _003C_003Em__0(KeyValuePair<string, JSONNode> k)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003FF4")]
	private sealed class _003C_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x401AEB1")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<string, JSONNode>.Enumerator _0024locvar0;

		[Token(Token = "0x401AEB2")]
		[FieldOffset(Offset = "0x1C")]
		internal KeyValuePair<string, JSONNode> _003CN_003E__1;

		[Token(Token = "0x401AEB3")]
		[FieldOffset(Offset = "0x24")]
		internal JSONObject _0024this;

		[Token(Token = "0x401AEB4")]
		[FieldOffset(Offset = "0x28")]
		internal JSONNode _0024current;

		[Token(Token = "0x401AEB5")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x401AEB6")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x17001C8F")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x601A0BC")]
			[Address(RVA = "0x21CDBC4", Offset = "0x21CDBC4", VA = "0x21CDBC4", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C90")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A0BD")]
			[Address(RVA = "0x21CDBCC", Offset = "0x21CDBCC", VA = "0x21CDBCC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A0BA")]
		[Address(RVA = "0x21CD55C", Offset = "0x21CD55C", VA = "0x21CD55C")]
		public _003C_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601A0BB")]
		[Address(RVA = "0x21CD9E0", Offset = "0x21CD9E0", VA = "0x21CD9E0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A0BE")]
		[Address(RVA = "0x21CDBD4", Offset = "0x21CDBD4", VA = "0x21CDBD4", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A0BF")]
		[Address(RVA = "0x21CDC54", Offset = "0x21CDC54", VA = "0x21CDC54", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x601A0C0")]
		[Address(RVA = "0x21CDCDC", Offset = "0x21CDCDC", VA = "0x21CDCDC", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x601A0C1")]
		[Address(RVA = "0x21CDCE0", Offset = "0x21CDCE0", VA = "0x21CDCE0", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x401AEAE")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, JSONNode> m_Dict;

	[Token(Token = "0x401AEAF")]
	[FieldOffset(Offset = "0xC")]
	private bool inline;

	[Token(Token = "0x17001C88")]
	public override bool Inline
	{
		[Token(Token = "0x601A0A8")]
		[Address(RVA = "0x21CC854", Offset = "0x21CC854", VA = "0x21CC854", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A0A9")]
		[Address(RVA = "0x21CC85C", Offset = "0x21CC85C", VA = "0x21CC85C", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17001C89")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x601A0AA")]
		[Address(RVA = "0x21CC864", Offset = "0x21CC864", VA = "0x21CC864", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17001C8A")]
	public override bool IsObject
	{
		[Token(Token = "0x601A0AB")]
		[Address(RVA = "0x21CC86C", Offset = "0x21CC86C", VA = "0x21CC86C", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C8B")]
	public override JSONNode Item
	{
		[Token(Token = "0x601A0AD")]
		[Address(RVA = "0x21CC928", Offset = "0x21CC928", VA = "0x21CC928", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0AE")]
		[Address(RVA = "0x21CCA0C", Offset = "0x21CCA0C", VA = "0x21CCA0C", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17001C8C")]
	public override JSONNode Item
	{
		[Token(Token = "0x601A0AF")]
		[Address(RVA = "0x21CCB68", Offset = "0x21CCB68", VA = "0x21CCB68", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A0B0")]
		[Address(RVA = "0x21CCC4C", Offset = "0x21CCC4C", VA = "0x21CCC4C", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17001C8D")]
	public override int Count
	{
		[Token(Token = "0x601A0B1")]
		[Address(RVA = "0x21CCDDC", Offset = "0x21CCDDC", VA = "0x21CCDDC", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C8E")]
	public override IEnumerable<JSONNode> Children
	{
		[Token(Token = "0x601A0B6")]
		[Address(RVA = "0x21CD4BC", Offset = "0x21CD4BC", VA = "0x21CD4BC", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A0A7")]
	[Address(RVA = "0x21C89EC", Offset = "0x21C89EC", VA = "0x21C89EC")]
	public JSONObject()
	{
	}

	[Token(Token = "0x601A0AC")]
	[Address(RVA = "0x21CC874", Offset = "0x21CC874", VA = "0x21CC874", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x601A0B2")]
	[Address(RVA = "0x21CCE54", Offset = "0x21CCE54", VA = "0x21CCE54", Slot = "20")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x601A0B3")]
	[Address(RVA = "0x21CD080", Offset = "0x21CD080", VA = "0x21CD080", Slot = "22")]
	public override JSONNode Remove(string aKey)
	{
		return null;
	}

	[Token(Token = "0x601A0B4")]
	[Address(RVA = "0x21CD174", Offset = "0x21CD174", VA = "0x21CD174", Slot = "23")]
	public override JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x601A0B5")]
	[Address(RVA = "0x21CD2A4", Offset = "0x21CD2A4", VA = "0x21CD2A4", Slot = "24")]
	public override JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x601A0B7")]
	[Address(RVA = "0x21CD564", Offset = "0x21CD564", VA = "0x21CD564", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
