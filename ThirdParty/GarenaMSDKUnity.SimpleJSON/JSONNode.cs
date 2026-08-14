using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000017")]
public abstract class JSONNode
{
	[Token(Token = "0x2000018")]
	public struct Enumerator
	{
		[Token(Token = "0x2000019")]
		private enum Type
		{
			[Token(Token = "0x40000FC")]
			None,
			[Token(Token = "0x40000FD")]
			Array,
			[Token(Token = "0x40000FE")]
			Object
		}

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x0")]
		private Type type;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x4")]
		private Dictionary<string, JSONNode>.Enumerator m_Object;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x18")]
		private List<JSONNode>.Enumerator m_Array;

		[Token(Token = "0x17000023")]
		public bool IsValid
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x941958", Offset = "0x941958", VA = "0x941958")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public KeyValuePair<string, JSONNode> Current
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x941968", Offset = "0x941968", VA = "0x941968")]
			get
			{
				return default(KeyValuePair<string, JSONNode>);
			}
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x9418F4", Offset = "0x9418F4", VA = "0x9418F4")]
		public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x941928", Offset = "0x941928", VA = "0x941928")]
		public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x94197C", Offset = "0x94197C", VA = "0x94197C")]
		public bool MoveNext()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200001A")]
	public struct ValueEnumerator
	{
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		private Enumerator m_Enumerator;

		[Token(Token = "0x17000025")]
		public JSONNode Current
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x941BCC", Offset = "0x941BCC", VA = "0x941BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x941B1C", Offset = "0x941B1C", VA = "0x941B1C")]
		public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x941B50", Offset = "0x941B50", VA = "0x941B50")]
		public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x941B80", Offset = "0x941B80", VA = "0x941B80")]
		public ValueEnumerator(Enumerator aEnumerator)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x941BD4", Offset = "0x941BD4", VA = "0x941BD4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x941BDC", Offset = "0x941BDC", VA = "0x941BDC")]
		public ValueEnumerator GetEnumerator()
		{
			return default(ValueEnumerator);
		}
	}

	[Token(Token = "0x200001B")]
	public struct KeyEnumerator
	{
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x0")]
		private Enumerator m_Enumerator;

		[Token(Token = "0x17000026")]
		public JSONNode Current
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x941A90", Offset = "0x941A90", VA = "0x941A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x9419E0", Offset = "0x9419E0", VA = "0x9419E0")]
		public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x941A14", Offset = "0x941A14", VA = "0x941A14")]
		public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x941A44", Offset = "0x941A44", VA = "0x941A44")]
		public KeyEnumerator(Enumerator aEnumerator)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x941A98", Offset = "0x941A98", VA = "0x941A98")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x941AA0", Offset = "0x941AA0", VA = "0x941AA0")]
		public KeyEnumerator GetEnumerator()
		{
			return default(KeyEnumerator);
		}
	}

	[Token(Token = "0x200001C")]
	public class LinqEnumerator : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x8")]
		private JSONNode m_Node;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xC")]
		private Enumerator m_Enumerator;

		[Token(Token = "0x17000027")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x34FFAA4", Offset = "0x34FFAA4", VA = "0x34FFAA4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public KeyValuePair<string, JSONNode> Current
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x34FFA90", Offset = "0x34FFA90", VA = "0x34FFA90", Slot = "4")]
			get
			{
				return default(KeyValuePair<string, JSONNode>);
			}
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x34FF98C", Offset = "0x34FF98C", VA = "0x34FF98C")]
		internal LinqEnumerator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x34FFB28", Offset = "0x34FFB28", VA = "0x34FFB28", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x34FFB30", Offset = "0x34FFB30", VA = "0x34FFB30", Slot = "8")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x34FFB50", Offset = "0x34FFB50", VA = "0x34FFB50", Slot = "9")]
		public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x34FFBC4", Offset = "0x34FFBC4", VA = "0x34FFBC4", Slot = "7")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x34FFCB8", Offset = "0x34FFCB8", VA = "0x34FFCB8", Slot = "10")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x200001D")]
	private sealed class _003C_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x8")]
		internal JSONNode _0024current;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xC")]
		internal bool _0024disposing;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x17000029")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x34FEA08", Offset = "0x34FEA08", VA = "0x34FEA08", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x34FEA10", Offset = "0x34FEA10", VA = "0x34FEA10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x34FE9F0", Offset = "0x34FE9F0", VA = "0x34FE9F0")]
		public _003C_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x34FE9F8", Offset = "0x34FE9F8", VA = "0x34FE9F8", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x34FEA18", Offset = "0x34FEA18", VA = "0x34FEA18", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x34FEA1C", Offset = "0x34FEA1C", VA = "0x34FEA1C", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x34FEAA4", Offset = "0x34FEAA4", VA = "0x34FEAA4", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x34FEAA8", Offset = "0x34FEAA8", VA = "0x34FEAA8", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x200001E")]
	private sealed class _003C_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x8")]
		internal IEnumerator<JSONNode> _0024locvar0;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xC")]
		internal JSONNode _003CC_003E__1;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x10")]
		internal IEnumerator<JSONNode> _0024locvar1;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x14")]
		internal JSONNode _003CD_003E__2;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x18")]
		internal JSONNode _0024this;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x1C")]
		internal JSONNode _0024current;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x1700002B")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x34FF270", Offset = "0x34FF270", VA = "0x34FF270", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x34FF278", Offset = "0x34FF278", VA = "0x34FF278", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x34FEB34", Offset = "0x34FEB34", VA = "0x34FEB34")]
		public _003C_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x34FEB3C", Offset = "0x34FEB3C", VA = "0x34FEB3C", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x34FF280", Offset = "0x34FF280", VA = "0x34FF280", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x34FF444", Offset = "0x34FF444", VA = "0x34FF444", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x34FF4CC", Offset = "0x34FF4CC", VA = "0x34FF4CC", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x34FF4D0", Offset = "0x34FF4D0", VA = "0x34FF4D0", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CGarenaMSDKUnity_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x0")]
	public static bool forceASCII;

	[Token(Token = "0x40000F7")]
	private static StringBuilder m_EscapeBuilder;

	[Token(Token = "0x1700000B")]
	public abstract JSONNodeType Tag
	{
		[Token(Token = "0x6000090")]
		get;
	}

	[Token(Token = "0x1700000C")]
	public virtual JSONNode Item
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x346B9E4", Offset = "0x346B9E4", VA = "0x346B9E4", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x346B9EC", Offset = "0x346B9EC", VA = "0x346B9EC", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public virtual JSONNode Item
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x346B9F0", Offset = "0x346B9F0", VA = "0x346B9F0", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x346B9F8", Offset = "0x346B9F8", VA = "0x346B9F8", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public virtual string Value
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x346B9FC", Offset = "0x346B9FC", VA = "0x346B9FC", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x346BA88", Offset = "0x346BA88", VA = "0x346BA88", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public virtual int Count
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x346BA8C", Offset = "0x346BA8C", VA = "0x346BA8C", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000010")]
	public virtual bool IsNumber
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x346BA94", Offset = "0x346BA94", VA = "0x346BA94", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public virtual bool IsString
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x346BA9C", Offset = "0x346BA9C", VA = "0x346BA9C", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public virtual bool IsBoolean
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x346BAA4", Offset = "0x346BAA4", VA = "0x346BAA4", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public virtual bool IsNull
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x346BAAC", Offset = "0x346BAAC", VA = "0x346BAAC", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public virtual bool IsArray
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x346BAB4", Offset = "0x346BAB4", VA = "0x346BAB4", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public virtual bool IsObject
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x346BABC", Offset = "0x346BABC", VA = "0x346BABC", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000016")]
	public virtual bool Inline
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x346BAC4", Offset = "0x346BAC4", VA = "0x346BAC4", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x346BACC", Offset = "0x346BACC", VA = "0x346BACC", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public virtual IEnumerable<JSONNode> Children
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x346BB98", Offset = "0x346BB98", VA = "0x346BB98", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public IEnumerable<JSONNode> DeepChildren
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x346BC1C", Offset = "0x346BC1C", VA = "0x346BC1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000019")]
	public IEnumerable<KeyValuePair<string, JSONNode>> Linq
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x346BE48", Offset = "0x346BE48", VA = "0x346BE48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public KeyEnumerator Keys
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x346BEBC", Offset = "0x346BEBC", VA = "0x346BEBC")]
		get
		{
			return default(KeyEnumerator);
		}
	}

	[Token(Token = "0x1700001B")]
	public ValueEnumerator Values
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x346BF30", Offset = "0x346BF30", VA = "0x346BF30")]
		get
		{
			return default(ValueEnumerator);
		}
	}

	[Token(Token = "0x1700001C")]
	public virtual double AsDouble
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x346BFA4", Offset = "0x346BFA4", VA = "0x346BFA4", Slot = "29")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x346BFF4", Offset = "0x346BFF4", VA = "0x346BFF4", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public virtual int AsInt
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x346C034", Offset = "0x346C034", VA = "0x346C034", Slot = "31")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x346C05C", Offset = "0x346C05C", VA = "0x346C05C", Slot = "32")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public virtual float AsFloat
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x346C090", Offset = "0x346C090", VA = "0x346C090", Slot = "33")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x346C0B8", Offset = "0x346C0B8", VA = "0x346C0B8", Slot = "34")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public virtual bool AsBool
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x346C0EC", Offset = "0x346C0EC", VA = "0x346C0EC", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x346C208", Offset = "0x346C208", VA = "0x346C208", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public virtual JSONArray AsArray
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x346C2A0", Offset = "0x346C2A0", VA = "0x346C2A0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public virtual JSONObject AsObject
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x346C334", Offset = "0x346C334", VA = "0x346C334", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	internal static StringBuilder EscapeBuilder
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x346CAF8", Offset = "0x346CAF8", VA = "0x346CAF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x3469B64", Offset = "0x3469B64", VA = "0x3469B64")]
	protected JSONNode()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x346BAD0", Offset = "0x346BAD0", VA = "0x346BAD0", Slot = "20")]
	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x346BAD4", Offset = "0x346BAD4", VA = "0x346BAD4", Slot = "21")]
	public virtual void Add(JSONNode aItem)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x346BB80", Offset = "0x346BB80", VA = "0x346BB80", Slot = "22")]
	public virtual JSONNode Remove(string aKey)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x346BB88", Offset = "0x346BB88", VA = "0x346BB88", Slot = "23")]
	public virtual JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x346BB90", Offset = "0x346BB90", VA = "0x346BB90", Slot = "24")]
	public virtual JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x346BCBC", Offset = "0x346BCBC", VA = "0x346BCBC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x346BD80", Offset = "0x346BD80", VA = "0x346BD80", Slot = "26")]
	public virtual string ToString(int aIndent)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	[Token(Token = "0x60000AA")]
	public abstract Enumerator GetEnumerator();

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x346C3C8", Offset = "0x346C3C8", VA = "0x346C3C8")]
	public static implicit operator JSONNode(string s)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x346C43C", Offset = "0x346C43C", VA = "0x346C43C")]
	public static implicit operator string(JSONNode d)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x346C4F0", Offset = "0x346C4F0", VA = "0x346C4F0")]
	public static implicit operator JSONNode(double n)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x346C57C", Offset = "0x346C57C", VA = "0x346C57C")]
	public static implicit operator double(JSONNode d)
	{
		return default(double);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x346C638", Offset = "0x346C638", VA = "0x346C638")]
	public static implicit operator JSONNode(float n)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x346C6C8", Offset = "0x346C6C8", VA = "0x346C6C8")]
	public static implicit operator float(JSONNode d)
	{
		return default(float);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x346C77C", Offset = "0x346C77C", VA = "0x346C77C")]
	public static implicit operator JSONNode(int n)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x346C808", Offset = "0x346C808", VA = "0x346C808")]
	public static implicit operator int(JSONNode d)
	{
		return default(int);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x346C8BC", Offset = "0x346C8BC", VA = "0x346C8BC")]
	public static implicit operator JSONNode(bool b)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x346C92C", Offset = "0x346C92C", VA = "0x346C92C")]
	public static implicit operator bool(JSONNode d)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x346C9E0", Offset = "0x346C9E0", VA = "0x346C9E0")]
	public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3469F34", Offset = "0x3469F34", VA = "0x3469F34")]
	public static bool operator ==(JSONNode a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x346CA50", Offset = "0x346CA50", VA = "0x346CA50")]
	public static bool operator !=(JSONNode a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x346CADC", Offset = "0x346CADC", VA = "0x346CADC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x346CAF0", Offset = "0x346CAF0", VA = "0x346CAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x346CC40", Offset = "0x346CC40", VA = "0x346CC40")]
	internal static string Escape(string aText)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x346D110", Offset = "0x346D110", VA = "0x346D110")]
	private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x3468F08", Offset = "0x3468F08", VA = "0x3468F08")]
	public static JSONNode Parse(string aJSON)
	{
		return null;
	}
}
