using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000021")]
public class JSONObject : JSONNode
{
	[Token(Token = "0x2000022")]
	private sealed class _003CRemove_003Ec__AnonStorey1
	{
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x8")]
		internal JSONNode aNode;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x3501458", Offset = "0x3501458", VA = "0x3501458")]
		public _003CRemove_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x3501D34", Offset = "0x3501D34", VA = "0x3501D34")]
		internal bool _003C_003Em__0(KeyValuePair<string, JSONNode> k)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000023")]
	private sealed class _003C_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<string, JSONNode>.Enumerator _0024locvar0;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x1C")]
		internal KeyValuePair<string, JSONNode> _003CN_003E__1;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x24")]
		internal JSONObject _0024this;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x28")]
		internal JSONNode _0024current;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x1700003D")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x3501B6C", Offset = "0x3501B6C", VA = "0x3501B6C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x3501B74", Offset = "0x3501B74", VA = "0x3501B74", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x3501500", Offset = "0x3501500", VA = "0x3501500")]
		public _003C_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x3501988", Offset = "0x3501988", VA = "0x3501988", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x3501B7C", Offset = "0x3501B7C", VA = "0x3501B7C", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x3501BFC", Offset = "0x3501BFC", VA = "0x3501BFC", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x3501C84", Offset = "0x3501C84", VA = "0x3501C84", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x3501C88", Offset = "0x3501C88", VA = "0x3501C88", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, JSONNode> m_Dict;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0xC")]
	private bool inline;

	[Token(Token = "0x17000036")]
	public override bool Inline
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x35007E8", Offset = "0x35007E8", VA = "0x35007E8", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x35007F0", Offset = "0x35007F0", VA = "0x35007F0", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public override JSONNodeType Tag
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x35007F8", Offset = "0x35007F8", VA = "0x35007F8", Slot = "4")]
		get
		{
			return default(JSONNodeType);
		}
	}

	[Token(Token = "0x17000038")]
	public override bool IsObject
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x3500800", Offset = "0x3500800", VA = "0x3500800", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000039")]
	public override JSONNode Item
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x35008BC", Offset = "0x35008BC", VA = "0x35008BC", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x35009A4", Offset = "0x35009A4", VA = "0x35009A4", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public override JSONNode Item
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x3500B04", Offset = "0x3500B04", VA = "0x3500B04", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x3500BE8", Offset = "0x3500BE8", VA = "0x3500BE8", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public override int Count
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x3500D7C", Offset = "0x3500D7C", VA = "0x3500D7C", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public override IEnumerable<JSONNode> Children
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x3501460", Offset = "0x3501460", VA = "0x3501460", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x3500730", Offset = "0x3500730", VA = "0x3500730")]
	public JSONObject()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x3500808", Offset = "0x3500808", VA = "0x3500808", Slot = "28")]
	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x3500DF4", Offset = "0x3500DF4", VA = "0x3500DF4", Slot = "20")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x3501024", Offset = "0x3501024", VA = "0x3501024", Slot = "22")]
	public override JSONNode Remove(string aKey)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x3501118", Offset = "0x3501118", VA = "0x3501118", Slot = "23")]
	public override JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x3501248", Offset = "0x3501248", VA = "0x3501248", Slot = "24")]
	public override JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x3501508", Offset = "0x3501508", VA = "0x3501508", Slot = "27")]
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
	}
}
