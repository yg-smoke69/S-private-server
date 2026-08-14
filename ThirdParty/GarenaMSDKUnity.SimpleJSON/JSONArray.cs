using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x200001F")]
public class JSONArray : JSONNode
{
	[Token(Token = "0x2000020")]
	private sealed class _003C_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x8")]
		internal List<JSONNode>.Enumerator _0024locvar0;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x18")]
		internal JSONNode _003CN_003E__1;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x1C")]
		internal JSONArray _0024this;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x20")]
		internal JSONNode _0024current;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17000034")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x346A9B4", Offset = "0x346A9B4", VA = "0x346A9B4", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x346A9BC", Offset = "0x346A9BC", VA = "0x346A9BC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x346A5AC", Offset = "0x346A5AC", VA = "0x346A5AC")]
		public _003C_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x346A7FC", Offset = "0x346A7FC", VA = "0x346A7FC", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x346A9C4", Offset = "0x346A9C4", VA = "0x346A9C4", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x346AA44", Offset = "0x346AA44", VA = "0x346AA44", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x346AACC", Offset = "0x346AACC", VA = "0x346AACC", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x346AAD0", Offset = "0x346AAD0", VA = "0x346AAD0", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x8")]
	private List<JSONNode> m_List;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0xC")]
	private bool inline;

	[Token(Token = "0x1700002D")]
	public override bool Inline
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x3469B6C", Offset = "0x3469B6C", VA = "0x3469B6C", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x3469B74", Offset = "0x3469B74", VA = "0x3469B74", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x3469B7C", Offset = "0x3469B7C", VA = "0x3469B7C", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x1700002F")]
	public override bool IsArray
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x3469B84", Offset = "0x3469B84", VA = "0x3469B84", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000030")]
	public override JSONNode Item
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x3469C48", Offset = "0x3469C48", VA = "0x3469C48", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x3469DC4", Offset = "0x3469DC4", VA = "0x3469DC4", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public override JSONNode Item
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x346A0B8", Offset = "0x346A0B8", VA = "0x346A0B8", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x346A128", Offset = "0x346A128", VA = "0x346A128", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public override int Count
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x346A220", Offset = "0x346A220", VA = "0x346A220", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000033")]
	public override IEnumerable<JSONNode> Children
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x346A50C", Offset = "0x346A50C", VA = "0x346A50C", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x3469AAC", Offset = "0x3469AAC", VA = "0x3469AAC")]
	public JSONArray()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3469B8C", Offset = "0x3469B8C", VA = "0x3469B8C", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x346A298", Offset = "0x346A298", VA = "0x346A298", Slot = "20")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x346A390", Offset = "0x346A390", VA = "0x346A390", Slot = "23")]
	public override JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x346A488", Offset = "0x346A488", VA = "0x346A488", Slot = "24")]
	public override JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x346A5B4", Offset = "0x346A5B4", VA = "0x346A5B4", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
