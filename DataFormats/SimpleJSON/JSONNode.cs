using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FE8")]
public abstract class JSONNode
{
	[Token(Token = "0x2003FE9")]
	public struct Enumerator
	{
		[Token(Token = "0x2003FEA")]
		private enum Type
		{
			[Token(Token = "0x401AE94")]
			None,
			[Token(Token = "0x401AE95")]
			Array,
			[Token(Token = "0x401AE96")]
			Object
		}

		[Token(Token = "0x401AE90")]
		[FieldOffset(Offset = "0x0")]
		private Type type;

		[Token(Token = "0x401AE91")]
		[FieldOffset(Offset = "0x4")]
		private Dictionary<string, JSONNode>.Enumerator m_Object;

		[Token(Token = "0x401AE92")]
		[FieldOffset(Offset = "0x18")]
		private List<JSONNode>.Enumerator m_Array;

		[Token(Token = "0x17001C75")]
		public bool IsValid
		{
			[Token(Token = "0x601A068")]
			[Address(RVA = "0x93C928", Offset = "0x93C928", VA = "0x93C928")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17001C76")]
		public KeyValuePair<string, JSONNode> Current
		{
			[Token(Token = "0x601A069")]
			[Address(RVA = "0x93C938", Offset = "0x93C938", VA = "0x93C938")]
			get
			{
				return default(KeyValuePair<string, JSONNode>);
			}
		}

		[Token(Token = "0x601A066")]
		[Address(RVA = "0x93C8C4", Offset = "0x93C8C4", VA = "0x93C8C4")]
		public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
		{
		}

		[Token(Token = "0x601A067")]
		[Address(RVA = "0x93C8F8", Offset = "0x93C8F8", VA = "0x93C8F8")]
		public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
		{
		}

		[Token(Token = "0x601A06A")]
		[Address(RVA = "0x93C94C", Offset = "0x93C94C", VA = "0x93C94C")]
		public bool MoveNext()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003FEB")]
	public struct ValueEnumerator
	{
		[Token(Token = "0x401AE97")]
		[FieldOffset(Offset = "0x0")]
		private Enumerator m_Enumerator;

		[Token(Token = "0x17001C77")]
		public JSONNode Current
		{
			[Token(Token = "0x601A06E")]
			[Address(RVA = "0x93CB9C", Offset = "0x93CB9C", VA = "0x93CB9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A06B")]
		[Address(RVA = "0x93CAEC", Offset = "0x93CAEC", VA = "0x93CAEC")]
		public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
		{
		}

		[Token(Token = "0x601A06C")]
		[Address(RVA = "0x93CB20", Offset = "0x93CB20", VA = "0x93CB20")]
		public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
		{
		}

		[Token(Token = "0x601A06D")]
		[Address(RVA = "0x93CB50", Offset = "0x93CB50", VA = "0x93CB50")]
		public ValueEnumerator(Enumerator aEnumerator)
		{
		}

		[Token(Token = "0x601A06F")]
		[Address(RVA = "0x93CBA4", Offset = "0x93CBA4", VA = "0x93CBA4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A070")]
		[Address(RVA = "0x93CBAC", Offset = "0x93CBAC", VA = "0x93CBAC")]
		public ValueEnumerator GetEnumerator()
		{
			return default(ValueEnumerator);
		}
	}

	[Token(Token = "0x2003FEC")]
	public struct KeyEnumerator
	{
		[Token(Token = "0x401AE98")]
		[FieldOffset(Offset = "0x0")]
		private Enumerator m_Enumerator;

		[Token(Token = "0x17001C78")]
		public JSONNode Current
		{
			[Token(Token = "0x601A074")]
			[Address(RVA = "0x93CA60", Offset = "0x93CA60", VA = "0x93CA60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A071")]
		[Address(RVA = "0x93C9B0", Offset = "0x93C9B0", VA = "0x93C9B0")]
		public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
		{
		}

		[Token(Token = "0x601A072")]
		[Address(RVA = "0x93C9E4", Offset = "0x93C9E4", VA = "0x93C9E4")]
		public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
		{
		}

		[Token(Token = "0x601A073")]
		[Address(RVA = "0x93CA14", Offset = "0x93CA14", VA = "0x93CA14")]
		public KeyEnumerator(Enumerator aEnumerator)
		{
		}

		[Token(Token = "0x601A075")]
		[Address(RVA = "0x93CA68", Offset = "0x93CA68", VA = "0x93CA68")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A076")]
		[Address(RVA = "0x93CA70", Offset = "0x93CA70", VA = "0x93CA70")]
		public KeyEnumerator GetEnumerator()
		{
			return default(KeyEnumerator);
		}
	}

	[Token(Token = "0x2003FED")]
	public class LinqEnumerator : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x401AE99")]
		[FieldOffset(Offset = "0x8")]
		private JSONNode m_Node;

		[Token(Token = "0x401AE9A")]
		[FieldOffset(Offset = "0xC")]
		private Enumerator m_Enumerator;

		[Token(Token = "0x17001C79")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A079")]
			[Address(RVA = "0x21CBD94", Offset = "0x21CBD94", VA = "0x21CBD94", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C7A")]
		public KeyValuePair<string, JSONNode> Current
		{
			[Token(Token = "0x601A078")]
			[Address(RVA = "0x21CBD80", Offset = "0x21CBD80", VA = "0x21CBD80", Slot = "4")]
			get
			{
				return default(KeyValuePair<string, JSONNode>);
			}
		}

		[Token(Token = "0x601A077")]
		[Address(RVA = "0x21C977C", Offset = "0x21C977C", VA = "0x21C977C")]
		internal LinqEnumerator(JSONNode aNode)
		{
		}

		[Token(Token = "0x601A07A")]
		[Address(RVA = "0x21CBE18", Offset = "0x21CBE18", VA = "0x21CBE18", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A07B")]
		[Address(RVA = "0x21CBE20", Offset = "0x21CBE20", VA = "0x21CBE20", Slot = "8")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A07C")]
		[Address(RVA = "0x21CBE40", Offset = "0x21CBE40", VA = "0x21CBE40", Slot = "9")]
		public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x601A07D")]
		[Address(RVA = "0x21CBEB4", Offset = "0x21CBEB4", VA = "0x21CBEB4", Slot = "7")]
		public void Reset()
		{
		}

		[Token(Token = "0x601A07E")]
		[Address(RVA = "0x21CBFA4", Offset = "0x21CBFA4", VA = "0x21CBFA4", Slot = "10")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2003FEE")]
	private sealed class _003C_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x401AE9B")]
		[FieldOffset(Offset = "0x8")]
		internal JSONNode _0024current;

		[Token(Token = "0x401AE9C")]
		[FieldOffset(Offset = "0xC")]
		internal bool _0024disposing;

		[Token(Token = "0x401AE9D")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x17001C7B")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x601A081")]
			[Address(RVA = "0x21CAE80", Offset = "0x21CAE80", VA = "0x21CAE80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C7C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A082")]
			[Address(RVA = "0x21CAE88", Offset = "0x21CAE88", VA = "0x21CAE88", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A07F")]
		[Address(RVA = "0x21C94D0", Offset = "0x21C94D0", VA = "0x21C94D0")]
		public _003C_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601A080")]
		[Address(RVA = "0x21CAE70", Offset = "0x21CAE70", VA = "0x21CAE70", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A083")]
		[Address(RVA = "0x21CAE90", Offset = "0x21CAE90", VA = "0x21CAE90", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A084")]
		[Address(RVA = "0x21CAE94", Offset = "0x21CAE94", VA = "0x21CAE94", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x601A085")]
		[Address(RVA = "0x21CAF1C", Offset = "0x21CAF1C", VA = "0x21CAF1C", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x601A086")]
		[Address(RVA = "0x21CAF20", Offset = "0x21CAF20", VA = "0x21CAF20", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2003FEF")]
	private sealed class _003C_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x401AE9E")]
		[FieldOffset(Offset = "0x8")]
		internal IEnumerator<JSONNode> _0024locvar0;

		[Token(Token = "0x401AE9F")]
		[FieldOffset(Offset = "0xC")]
		internal JSONNode _003CC_003E__1;

		[Token(Token = "0x401AEA0")]
		[FieldOffset(Offset = "0x10")]
		internal IEnumerator<JSONNode> _0024locvar1;

		[Token(Token = "0x401AEA1")]
		[FieldOffset(Offset = "0x14")]
		internal JSONNode _003CD_003E__2;

		[Token(Token = "0x401AEA2")]
		[FieldOffset(Offset = "0x18")]
		internal JSONNode _0024this;

		[Token(Token = "0x401AEA3")]
		[FieldOffset(Offset = "0x1C")]
		internal JSONNode _0024current;

		[Token(Token = "0x401AEA4")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x401AEA5")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17001C7D")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x601A089")]
			[Address(RVA = "0x21CB6DC", Offset = "0x21CB6DC", VA = "0x21CB6DC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C7E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A08A")]
			[Address(RVA = "0x21CB6E4", Offset = "0x21CB6E4", VA = "0x21CB6E4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A087")]
		[Address(RVA = "0x21C9578", Offset = "0x21C9578", VA = "0x21C9578")]
		public _003C_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x601A088")]
		[Address(RVA = "0x21CAFAC", Offset = "0x21CAFAC", VA = "0x21CAFAC", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A08B")]
		[Address(RVA = "0x21CB6EC", Offset = "0x21CB6EC", VA = "0x21CB6EC", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A08C")]
		[Address(RVA = "0x21CB8B0", Offset = "0x21CB8B0", VA = "0x21CB8B0", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x601A08D")]
		[Address(RVA = "0x21CB938", Offset = "0x21CB938", VA = "0x21CB938", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x601A08E")]
		[Address(RVA = "0x21CB93C", Offset = "0x21CB93C", VA = "0x21CB93C", Slot = "5")]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x401AE8E")]
	[FieldOffset(Offset = "0x0")]
	public static bool forceASCII;

	[Token(Token = "0x401AE8F")]
	private static StringBuilder m_EscapeBuilder;

	[Token(Token = "0x17001C5D")]
	public abstract JSONNodeType Tag
	{
		[Token(Token = "0x601A02A")]
		get;
	}

	[Token(Token = "0x17001C5E")]
	public virtual JSONNode Item
	{
		[Token(Token = "0x601A02B")]
		[Address(RVA = "0x21C9298", Offset = "0x21C9298", VA = "0x21C9298", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A02C")]
		[Address(RVA = "0x21C92A0", Offset = "0x21C92A0", VA = "0x21C92A0", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17001C5F")]
	public virtual JSONNode Item
	{
		[Token(Token = "0x601A02D")]
		[Address(RVA = "0x21C92A4", Offset = "0x21C92A4", VA = "0x21C92A4", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A02E")]
		[Address(RVA = "0x21C92AC", Offset = "0x21C92AC", VA = "0x21C92AC", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17001C60")]
	public virtual string Value
	{
		[Token(Token = "0x601A02F")]
		[Address(RVA = "0x21C92B0", Offset = "0x21C92B0", VA = "0x21C92B0", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A030")]
		[Address(RVA = "0x21C933C", Offset = "0x21C933C", VA = "0x21C933C", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17001C61")]
	public virtual int Count
	{
		[Token(Token = "0x601A031")]
		[Address(RVA = "0x21C9340", Offset = "0x21C9340", VA = "0x21C9340", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C62")]
	public virtual bool IsNumber
	{
		[Token(Token = "0x601A032")]
		[Address(RVA = "0x21C9348", Offset = "0x21C9348", VA = "0x21C9348", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C63")]
	public virtual bool IsString
	{
		[Token(Token = "0x601A033")]
		[Address(RVA = "0x21C9350", Offset = "0x21C9350", VA = "0x21C9350", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C64")]
	public virtual bool IsBoolean
	{
		[Token(Token = "0x601A034")]
		[Address(RVA = "0x21C9358", Offset = "0x21C9358", VA = "0x21C9358", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C65")]
	public virtual bool IsNull
	{
		[Token(Token = "0x601A035")]
		[Address(RVA = "0x21C9360", Offset = "0x21C9360", VA = "0x21C9360", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C66")]
	public virtual bool IsArray
	{
		[Token(Token = "0x601A036")]
		[Address(RVA = "0x21C9368", Offset = "0x21C9368", VA = "0x21C9368", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C67")]
	public virtual bool IsObject
	{
		[Token(Token = "0x601A037")]
		[Address(RVA = "0x21C9370", Offset = "0x21C9370", VA = "0x21C9370", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C68")]
	public virtual bool Inline
	{
		[Token(Token = "0x601A038")]
		[Address(RVA = "0x21C9378", Offset = "0x21C9378", VA = "0x21C9378", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A039")]
		[Address(RVA = "0x21C9380", Offset = "0x21C9380", VA = "0x21C9380", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17001C69")]
	public virtual IEnumerable<JSONNode> Children
	{
		[Token(Token = "0x601A03F")]
		[Address(RVA = "0x21C944C", Offset = "0x21C944C", VA = "0x21C944C", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C6A")]
	public IEnumerable<JSONNode> DeepChildren
	{
		[Token(Token = "0x601A040")]
		[Address(RVA = "0x21C94D8", Offset = "0x21C94D8", VA = "0x21C94D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C6B")]
	public IEnumerable<KeyValuePair<string, JSONNode>> Linq
	{
		[Token(Token = "0x601A045")]
		[Address(RVA = "0x21C970C", Offset = "0x21C970C", VA = "0x21C970C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C6C")]
	public KeyEnumerator Keys
	{
		[Token(Token = "0x601A046")]
		[Address(RVA = "0x21C987C", Offset = "0x21C987C", VA = "0x21C987C")]
		get
		{
			return default(KeyEnumerator);
		}
	}

	[Token(Token = "0x17001C6D")]
	public ValueEnumerator Values
	{
		[Token(Token = "0x601A047")]
		[Address(RVA = "0x21C9910", Offset = "0x21C9910", VA = "0x21C9910")]
		get
		{
			return default(ValueEnumerator);
		}
	}

	[Token(Token = "0x17001C6E")]
	public virtual double AsDouble
	{
		[Token(Token = "0x601A048")]
		[Address(RVA = "0x21C99A4", Offset = "0x21C99A4", VA = "0x21C99A4", Slot = "29")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x601A049")]
		[Address(RVA = "0x21C99F4", Offset = "0x21C99F4", VA = "0x21C99F4", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x17001C6F")]
	public virtual int AsInt
	{
		[Token(Token = "0x601A04A")]
		[Address(RVA = "0x21C9A34", Offset = "0x21C9A34", VA = "0x21C9A34", Slot = "31")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601A04B")]
		[Address(RVA = "0x21C9A5C", Offset = "0x21C9A5C", VA = "0x21C9A5C", Slot = "32")]
		set
		{
		}
	}

	[Token(Token = "0x17001C70")]
	public virtual float AsFloat
	{
		[Token(Token = "0x601A04C")]
		[Address(RVA = "0x21C9A90", Offset = "0x21C9A90", VA = "0x21C9A90", Slot = "33")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601A04D")]
		[Address(RVA = "0x21C9AB8", Offset = "0x21C9AB8", VA = "0x21C9AB8", Slot = "34")]
		set
		{
		}
	}

	[Token(Token = "0x17001C71")]
	public virtual bool AsBool
	{
		[Token(Token = "0x601A04E")]
		[Address(RVA = "0x21C9AEC", Offset = "0x21C9AEC", VA = "0x21C9AEC", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A04F")]
		[Address(RVA = "0x21C9C08", Offset = "0x21C9C08", VA = "0x21C9C08", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x17001C72")]
	public virtual JSONArray AsArray
	{
		[Token(Token = "0x601A050")]
		[Address(RVA = "0x21C9CA0", Offset = "0x21C9CA0", VA = "0x21C9CA0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C73")]
	public virtual JSONObject AsObject
	{
		[Token(Token = "0x601A051")]
		[Address(RVA = "0x21C9D34", Offset = "0x21C9D34", VA = "0x21C9D34", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C74")]
	internal static StringBuilder EscapeBuilder
	{
		[Token(Token = "0x601A061")]
		[Address(RVA = "0x21CA55C", Offset = "0x21CA55C", VA = "0x21CA55C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A029")]
	[Address(RVA = "0x21C7218", Offset = "0x21C7218", VA = "0x21C7218")]
	protected JSONNode()
	{
	}

	[Token(Token = "0x601A03A")]
	[Address(RVA = "0x21C9384", Offset = "0x21C9384", VA = "0x21C9384", Slot = "20")]
	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x601A03B")]
	[Address(RVA = "0x21C9388", Offset = "0x21C9388", VA = "0x21C9388", Slot = "21")]
	public virtual void Add(JSONNode aItem)
	{
	}

	[Token(Token = "0x601A03C")]
	[Address(RVA = "0x21C9434", Offset = "0x21C9434", VA = "0x21C9434", Slot = "22")]
	public virtual JSONNode Remove(string aKey)
	{
		return null;
	}

	[Token(Token = "0x601A03D")]
	[Address(RVA = "0x21C943C", Offset = "0x21C943C", VA = "0x21C943C", Slot = "23")]
	public virtual JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x601A03E")]
	[Address(RVA = "0x21C9444", Offset = "0x21C9444", VA = "0x21C9444", Slot = "24")]
	public virtual JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x601A041")]
	[Address(RVA = "0x21C9580", Offset = "0x21C9580", VA = "0x21C9580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x601A042")]
	[Address(RVA = "0x21C9644", Offset = "0x21C9644", VA = "0x21C9644", Slot = "26")]
	public virtual string ToString(int aIndent)
	{
		return null;
	}

	[Token(Token = "0x601A043")]
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	[Token(Token = "0x601A044")]
	public abstract Enumerator GetEnumerator();

	[Token(Token = "0x601A052")]
	[Address(RVA = "0x21C9DC8", Offset = "0x21C9DC8", VA = "0x21C9DC8")]
	public static implicit operator JSONNode(string s)
	{
		return null;
	}

	[Token(Token = "0x601A053")]
	[Address(RVA = "0x21C9EC4", Offset = "0x21C9EC4", VA = "0x21C9EC4")]
	public static implicit operator string(JSONNode d)
	{
		return null;
	}

	[Token(Token = "0x601A054")]
	[Address(RVA = "0x21C9F78", Offset = "0x21C9F78", VA = "0x21C9F78")]
	public static implicit operator JSONNode(double n)
	{
		return null;
	}

	[Token(Token = "0x601A055")]
	[Address(RVA = "0x21C9FF8", Offset = "0x21C9FF8", VA = "0x21C9FF8")]
	public static implicit operator double(JSONNode d)
	{
		return default(double);
	}

	[Token(Token = "0x601A056")]
	[Address(RVA = "0x21CA0B4", Offset = "0x21CA0B4", VA = "0x21CA0B4")]
	public static implicit operator JSONNode(float n)
	{
		return null;
	}

	[Token(Token = "0x601A057")]
	[Address(RVA = "0x21CA138", Offset = "0x21CA138", VA = "0x21CA138")]
	public static implicit operator float(JSONNode d)
	{
		return default(float);
	}

	[Token(Token = "0x601A058")]
	[Address(RVA = "0x21CA1EC", Offset = "0x21CA1EC", VA = "0x21CA1EC")]
	public static implicit operator JSONNode(int n)
	{
		return null;
	}

	[Token(Token = "0x601A059")]
	[Address(RVA = "0x21CA26C", Offset = "0x21CA26C", VA = "0x21CA26C")]
	public static implicit operator int(JSONNode d)
	{
		return default(int);
	}

	[Token(Token = "0x601A05A")]
	[Address(RVA = "0x21CA320", Offset = "0x21CA320", VA = "0x21CA320")]
	public static implicit operator JSONNode(bool b)
	{
		return null;
	}

	[Token(Token = "0x601A05B")]
	[Address(RVA = "0x21CA390", Offset = "0x21CA390", VA = "0x21CA390")]
	public static implicit operator bool(JSONNode d)
	{
		return default(bool);
	}

	[Token(Token = "0x601A05C")]
	[Address(RVA = "0x21CA444", Offset = "0x21CA444", VA = "0x21CA444")]
	public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
	{
		return null;
	}

	[Token(Token = "0x601A05D")]
	[Address(RVA = "0x21C7614", Offset = "0x21C7614", VA = "0x21C7614")]
	public static bool operator ==(JSONNode a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x601A05E")]
	[Address(RVA = "0x21CA4B4", Offset = "0x21CA4B4", VA = "0x21CA4B4")]
	public static bool operator !=(JSONNode a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x601A05F")]
	[Address(RVA = "0x21CA540", Offset = "0x21CA540", VA = "0x21CA540", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601A060")]
	[Address(RVA = "0x21CA554", Offset = "0x21CA554", VA = "0x21CA554", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x601A062")]
	[Address(RVA = "0x21CA6A4", Offset = "0x21CA6A4", VA = "0x21CA6A4")]
	internal static string Escape(string aText)
	{
		return null;
	}

	[Token(Token = "0x601A063")]
	[Address(RVA = "0x21CAB74", Offset = "0x21CAB74", VA = "0x21CAB74")]
	private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
	{
	}

	[Token(Token = "0x601A064")]
	[Address(RVA = "0x21C65C0", Offset = "0x21C65C0", VA = "0x21C65C0")]
	public static JSONNode Parse(string aJSON)
	{
		return null;
	}
}
