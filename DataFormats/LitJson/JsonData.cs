using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B75")]
public class JsonData : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable, IEquatable<long>, IConvertible
{
	[Token(Token = "0x4019559")]
	[FieldOffset(Offset = "0x8")]
	private IList<JsonData> inst_array;

	[Token(Token = "0x401955A")]
	[FieldOffset(Offset = "0xC")]
	private bool inst_boolean;

	[Token(Token = "0x401955B")]
	[FieldOffset(Offset = "0x10")]
	private double inst_double;

	[Token(Token = "0x401955C")]
	[FieldOffset(Offset = "0x18")]
	private int inst_int;

	[Token(Token = "0x401955D")]
	[FieldOffset(Offset = "0x20")]
	private long inst_long;

	[Token(Token = "0x401955E")]
	[FieldOffset(Offset = "0x28")]
	private IDictionary<string, JsonData> inst_object;

	[Token(Token = "0x401955F")]
	[FieldOffset(Offset = "0x2C")]
	private string inst_string;

	[Token(Token = "0x4019560")]
	[FieldOffset(Offset = "0x30")]
	private string json;

	[Token(Token = "0x4019561")]
	[FieldOffset(Offset = "0x34")]
	private JsonType type;

	[Token(Token = "0x4019562")]
	[FieldOffset(Offset = "0x38")]
	private IList<KeyValuePair<string, JsonData>> object_list;

	[Token(Token = "0x1700182D")]
	private int System_002ECollections_002EICollection_002ECount
	{
		[Token(Token = "0x6017AD1")]
		[Address(RVA = "0x3118CD8", Offset = "0x3118CD8", VA = "0x3118CD8", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700182E")]
	private bool System_002ECollections_002EICollection_002EIsSynchronized
	{
		[Token(Token = "0x6017AD2")]
		[Address(RVA = "0x3118CDC", Offset = "0x3118CDC", VA = "0x3118CDC", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700182F")]
	private object System_002ECollections_002EICollection_002ESyncRoot
	{
		[Token(Token = "0x6017AD3")]
		[Address(RVA = "0x3118DBC", Offset = "0x3118DBC", VA = "0x3118DBC", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001830")]
	private bool System_002ECollections_002EIDictionary_002EIsFixedSize
	{
		[Token(Token = "0x6017AD4")]
		[Address(RVA = "0x3118E9C", Offset = "0x3118E9C", VA = "0x3118E9C", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001831")]
	private bool System_002ECollections_002EIDictionary_002EIsReadOnly
	{
		[Token(Token = "0x6017AD5")]
		[Address(RVA = "0x3119148", Offset = "0x3119148", VA = "0x3119148", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001832")]
	private ICollection System_002ECollections_002EIDictionary_002EKeys
	{
		[Token(Token = "0x6017AD6")]
		[Address(RVA = "0x3119228", Offset = "0x3119228", VA = "0x3119228", Slot = "50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001833")]
	private ICollection System_002ECollections_002EIDictionary_002EValues
	{
		[Token(Token = "0x6017AD7")]
		[Address(RVA = "0x31196C4", Offset = "0x31196C4", VA = "0x31196C4", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001834")]
	private bool LitJson_002EIJsonWrapper_002EIsArray
	{
		[Token(Token = "0x6017AD8")]
		[Address(RVA = "0x3119B60", Offset = "0x3119B60", VA = "0x3119B60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001835")]
	private bool LitJson_002EIJsonWrapper_002EIsBoolean
	{
		[Token(Token = "0x6017AD9")]
		[Address(RVA = "0x3119B74", Offset = "0x3119B74", VA = "0x3119B74", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001836")]
	private bool LitJson_002EIJsonWrapper_002EIsDouble
	{
		[Token(Token = "0x6017ADA")]
		[Address(RVA = "0x3119B88", Offset = "0x3119B88", VA = "0x3119B88", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001837")]
	private bool LitJson_002EIJsonWrapper_002EIsInt
	{
		[Token(Token = "0x6017ADB")]
		[Address(RVA = "0x3119B9C", Offset = "0x3119B9C", VA = "0x3119B9C", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001838")]
	private bool LitJson_002EIJsonWrapper_002EIsLong
	{
		[Token(Token = "0x6017ADC")]
		[Address(RVA = "0x3119BB0", Offset = "0x3119BB0", VA = "0x3119BB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001839")]
	private bool LitJson_002EIJsonWrapper_002EIsObject
	{
		[Token(Token = "0x6017ADD")]
		[Address(RVA = "0x3119BC4", Offset = "0x3119BC4", VA = "0x3119BC4", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700183A")]
	private bool LitJson_002EIJsonWrapper_002EIsString
	{
		[Token(Token = "0x6017ADE")]
		[Address(RVA = "0x3119BD4", Offset = "0x3119BD4", VA = "0x3119BD4", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700183B")]
	private bool System_002ECollections_002EIList_002EIsFixedSize
	{
		[Token(Token = "0x6017ADF")]
		[Address(RVA = "0x3119BE8", Offset = "0x3119BE8", VA = "0x3119BE8", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700183C")]
	private bool System_002ECollections_002EIList_002EIsReadOnly
	{
		[Token(Token = "0x6017AE0")]
		[Address(RVA = "0x3119E60", Offset = "0x3119E60", VA = "0x3119E60", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700183D")]
	private object System_002ECollections_002EIDictionary_002EItem
	{
		[Token(Token = "0x6017AE1")]
		[Address(RVA = "0x3119F40", Offset = "0x3119F40", VA = "0x3119F40", Slot = "48")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017AE2")]
		[Address(RVA = "0x311A028", Offset = "0x311A028", VA = "0x311A028", Slot = "49")]
		set
		{
		}
	}

	[Token(Token = "0x1700183E")]
	private object System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EItem
	{
		[Token(Token = "0x6017AE3")]
		[Address(RVA = "0x311A71C", Offset = "0x311A71C", VA = "0x311A71C", Slot = "44")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017AE4")]
		[Address(RVA = "0x311A838", Offset = "0x311A838", VA = "0x311A838", Slot = "45")]
		set
		{
		}
	}

	[Token(Token = "0x1700183F")]
	private object System_002ECollections_002EIList_002EItem
	{
		[Token(Token = "0x6017AE5")]
		[Address(RVA = "0x311AAE4", Offset = "0x311AAE4", VA = "0x311AAE4", Slot = "27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017AE6")]
		[Address(RVA = "0x311ABCC", Offset = "0x311ABCC", VA = "0x311ABCC", Slot = "28")]
		set
		{
		}
	}

	[Token(Token = "0x17001840")]
	public int Count
	{
		[Token(Token = "0x6017AC9")]
		[Address(RVA = "0x3118A0C", Offset = "0x3118A0C", VA = "0x3118A0C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001841")]
	public bool IsArray
	{
		[Token(Token = "0x6017ACA")]
		[Address(RVA = "0x3118C50", Offset = "0x3118C50", VA = "0x3118C50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001842")]
	public bool IsBoolean
	{
		[Token(Token = "0x6017ACB")]
		[Address(RVA = "0x3118C64", Offset = "0x3118C64", VA = "0x3118C64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001843")]
	public bool IsDouble
	{
		[Token(Token = "0x6017ACC")]
		[Address(RVA = "0x3118C78", Offset = "0x3118C78", VA = "0x3118C78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001844")]
	public bool IsInt
	{
		[Token(Token = "0x6017ACD")]
		[Address(RVA = "0x3118C8C", Offset = "0x3118C8C", VA = "0x3118C8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001845")]
	public bool IsLong
	{
		[Token(Token = "0x6017ACE")]
		[Address(RVA = "0x3118CA0", Offset = "0x3118CA0", VA = "0x3118CA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001846")]
	public bool IsObject
	{
		[Token(Token = "0x6017ACF")]
		[Address(RVA = "0x3118CB4", Offset = "0x3118CB4", VA = "0x3118CB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001847")]
	public bool IsString
	{
		[Token(Token = "0x6017AD0")]
		[Address(RVA = "0x3118CC4", Offset = "0x3118CC4", VA = "0x3118CC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001848")]
	public JsonData Item
	{
		[Token(Token = "0x6017AE9")]
		[Address(RVA = "0x311B124", Offset = "0x311B124", VA = "0x311B124")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017AEA")]
		[Address(RVA = "0x311A238", Offset = "0x311A238", VA = "0x311A238")]
		set
		{
		}
	}

	[Token(Token = "0x17001849")]
	public JsonData Item
	{
		[Token(Token = "0x6017AEB")]
		[Address(RVA = "0x311B20C", Offset = "0x311B20C", VA = "0x311B20C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017AEC")]
		[Address(RVA = "0x311AC00", Offset = "0x311AC00", VA = "0x311AC00")]
		set
		{
		}
	}

	[Token(Token = "0x6017AC2")]
	[Address(RVA = "0x3118708", Offset = "0x3118708", VA = "0x3118708")]
	public JsonData()
	{
	}

	[Token(Token = "0x6017AC3")]
	[Address(RVA = "0x3118710", Offset = "0x3118710", VA = "0x3118710")]
	public JsonData(bool boolean)
	{
	}

	[Token(Token = "0x6017AC4")]
	[Address(RVA = "0x3118738", Offset = "0x3118738", VA = "0x3118738")]
	public JsonData(double number)
	{
	}

	[Token(Token = "0x6017AC5")]
	[Address(RVA = "0x3118768", Offset = "0x3118768", VA = "0x3118768")]
	public JsonData(int number)
	{
	}

	[Token(Token = "0x6017AC6")]
	[Address(RVA = "0x3118790", Offset = "0x3118790", VA = "0x3118790")]
	public JsonData(long number)
	{
	}

	[Token(Token = "0x6017AC7")]
	[Address(RVA = "0x31187C0", Offset = "0x31187C0", VA = "0x31187C0")]
	public JsonData(object obj)
	{
	}

	[Token(Token = "0x6017AC8")]
	[Address(RVA = "0x31189E4", Offset = "0x31189E4", VA = "0x31189E4")]
	public JsonData(string str)
	{
	}

	[Token(Token = "0x6017AE7")]
	[Address(RVA = "0x311AF4C", Offset = "0x311AF4C", VA = "0x311AF4C")]
	public bool ContainsKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6017AE8")]
	[Address(RVA = "0x311B034", Offset = "0x311B034", VA = "0x311B034")]
	public bool TryGetValue(string key, out JsonData value)
	{
		return default(bool);
	}

	[Token(Token = "0x6017AED")]
	[Address(RVA = "0x311B3C8", Offset = "0x311B3C8", VA = "0x311B3C8")]
	public static implicit operator JsonData(bool data)
	{
		return null;
	}

	[Token(Token = "0x6017AEE")]
	[Address(RVA = "0x311B444", Offset = "0x311B444", VA = "0x311B444")]
	public static implicit operator JsonData(double data)
	{
		return null;
	}

	[Token(Token = "0x6017AEF")]
	[Address(RVA = "0x311B4C8", Offset = "0x311B4C8", VA = "0x311B4C8")]
	public static implicit operator JsonData(int data)
	{
		return null;
	}

	[Token(Token = "0x6017AF0")]
	[Address(RVA = "0x311B544", Offset = "0x311B544", VA = "0x311B544")]
	public static implicit operator JsonData(long data)
	{
		return null;
	}

	[Token(Token = "0x6017AF1")]
	[Address(RVA = "0x311B5C8", Offset = "0x311B5C8", VA = "0x311B5C8")]
	public static implicit operator JsonData(string data)
	{
		return null;
	}

	[Token(Token = "0x6017AF2")]
	[Address(RVA = "0x311B644", Offset = "0x311B644", VA = "0x311B644")]
	public static explicit operator bool(JsonData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6017AF3")]
	[Address(RVA = "0x311B704", Offset = "0x311B704", VA = "0x311B704")]
	public static explicit operator double(JsonData data)
	{
		return default(double);
	}

	[Token(Token = "0x6017AF4")]
	[Address(RVA = "0x311B7C8", Offset = "0x311B7C8", VA = "0x311B7C8")]
	public static explicit operator int(JsonData data)
	{
		return default(int);
	}

	[Token(Token = "0x6017AF5")]
	[Address(RVA = "0x311B888", Offset = "0x311B888", VA = "0x311B888")]
	public static explicit operator long(JsonData data)
	{
		return default(long);
	}

	[Token(Token = "0x6017AF6")]
	[Address(RVA = "0x311B948", Offset = "0x311B948", VA = "0x311B948")]
	public static explicit operator string(JsonData data)
	{
		return null;
	}

	[Token(Token = "0x6017AF7")]
	[Address(RVA = "0x311BA08", Offset = "0x311BA08", VA = "0x311BA08", Slot = "40")]
	private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
	{
	}

	[Token(Token = "0x6017AF8")]
	[Address(RVA = "0x311BAF8", Offset = "0x311BAF8", VA = "0x311BAF8", Slot = "52")]
	private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
	{
	}

	[Token(Token = "0x6017AF9")]
	[Address(RVA = "0x311BD44", Offset = "0x311BD44", VA = "0x311BD44", Slot = "53")]
	private void System_002ECollections_002EIDictionary_002EClear()
	{
	}

	[Token(Token = "0x6017AFA")]
	[Address(RVA = "0x311BEB8", Offset = "0x311BEB8", VA = "0x311BEB8", Slot = "54")]
	private bool System_002ECollections_002EIDictionary_002EContains(object key)
	{
		return default(bool);
	}

	[Token(Token = "0x6017AFB")]
	[Address(RVA = "0x311BFA0", Offset = "0x311BFA0", VA = "0x311BFA0", Slot = "55")]
	private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6017AFC")]
	[Address(RVA = "0x311C064", Offset = "0x311C064", VA = "0x311C064", Slot = "56")]
	private void System_002ECollections_002EIDictionary_002ERemove(object key)
	{
	}

	[Token(Token = "0x6017AFD")]
	[Address(RVA = "0x311C444", Offset = "0x311C444", VA = "0x311C444", Slot = "36")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6017AFE")]
	[Address(RVA = "0x311C524", Offset = "0x311C524", VA = "0x311C524", Slot = "11")]
	private bool LitJson_002EIJsonWrapper_002EGetBoolean()
	{
		return default(bool);
	}

	[Token(Token = "0x6017AFF")]
	[Address(RVA = "0x311C5D4", Offset = "0x311C5D4", VA = "0x311C5D4", Slot = "12")]
	private double LitJson_002EIJsonWrapper_002EGetDouble()
	{
		return default(double);
	}

	[Token(Token = "0x6017B00")]
	[Address(RVA = "0x311C688", Offset = "0x311C688", VA = "0x311C688", Slot = "13")]
	private int LitJson_002EIJsonWrapper_002EGetInt()
	{
		return default(int);
	}

	[Token(Token = "0x6017B01")]
	[Address(RVA = "0x311C738", Offset = "0x311C738", VA = "0x311C738", Slot = "15")]
	private long LitJson_002EIJsonWrapper_002EGetLong()
	{
		return default(long);
	}

	[Token(Token = "0x6017B02")]
	[Address(RVA = "0x311C7E8", Offset = "0x311C7E8", VA = "0x311C7E8", Slot = "16")]
	private string LitJson_002EIJsonWrapper_002EGetString()
	{
		return null;
	}

	[Token(Token = "0x6017B03")]
	[Address(RVA = "0x311C898", Offset = "0x311C898", VA = "0x311C898", Slot = "17")]
	private void LitJson_002EIJsonWrapper_002ESetBoolean(bool val)
	{
	}

	[Token(Token = "0x6017B04")]
	[Address(RVA = "0x311C8B0", Offset = "0x311C8B0", VA = "0x311C8B0", Slot = "18")]
	private void LitJson_002EIJsonWrapper_002ESetDouble(double val)
	{
	}

	[Token(Token = "0x6017B05")]
	[Address(RVA = "0x311C8D0", Offset = "0x311C8D0", VA = "0x311C8D0", Slot = "19")]
	private void LitJson_002EIJsonWrapper_002ESetInt(int val)
	{
	}

	[Token(Token = "0x6017B06")]
	[Address(RVA = "0x311C8E8", Offset = "0x311C8E8", VA = "0x311C8E8", Slot = "21")]
	private void LitJson_002EIJsonWrapper_002ESetLong(long val)
	{
	}

	[Token(Token = "0x6017B07")]
	[Address(RVA = "0x311C908", Offset = "0x311C908", VA = "0x311C908", Slot = "22")]
	private void LitJson_002EIJsonWrapper_002ESetString(string val)
	{
	}

	[Token(Token = "0x6017B08")]
	[Address(RVA = "0x311C920", Offset = "0x311C920", VA = "0x311C920", Slot = "23")]
	private string LitJson_002EIJsonWrapper_002EToJson()
	{
		return null;
	}

	[Token(Token = "0x6017B09")]
	[Address(RVA = "0x311CA08", Offset = "0x311CA08", VA = "0x311CA08", Slot = "24")]
	private void LitJson_002EIJsonWrapper_002EToJson(JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B0A")]
	[Address(RVA = "0x311CA78", Offset = "0x311CA78", VA = "0x311CA78", Slot = "29")]
	private int System_002ECollections_002EIList_002EAdd(object value)
	{
		return default(int);
	}

	[Token(Token = "0x6017B0B")]
	[Address(RVA = "0x311CB78", Offset = "0x311CB78", VA = "0x311CB78", Slot = "30")]
	private void System_002ECollections_002EIList_002EClear()
	{
	}

	[Token(Token = "0x6017B0C")]
	[Address(RVA = "0x311CC60", Offset = "0x311CC60", VA = "0x311CC60", Slot = "31")]
	private bool System_002ECollections_002EIList_002EContains(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6017B0D")]
	[Address(RVA = "0x311CD48", Offset = "0x311CD48", VA = "0x311CD48", Slot = "32")]
	private int System_002ECollections_002EIList_002EIndexOf(object value)
	{
		return default(int);
	}

	[Token(Token = "0x6017B0E")]
	[Address(RVA = "0x311CE30", Offset = "0x311CE30", VA = "0x311CE30", Slot = "33")]
	private void System_002ECollections_002EIList_002EInsert(int index, object value)
	{
	}

	[Token(Token = "0x6017B0F")]
	[Address(RVA = "0x311CF30", Offset = "0x311CF30", VA = "0x311CF30", Slot = "34")]
	private void System_002ECollections_002EIList_002ERemove(object value)
	{
	}

	[Token(Token = "0x6017B10")]
	[Address(RVA = "0x311D020", Offset = "0x311D020", VA = "0x311D020", Slot = "35")]
	private void System_002ECollections_002EIList_002ERemoveAt(int index)
	{
	}

	[Token(Token = "0x6017B11")]
	[Address(RVA = "0x311D110", Offset = "0x311D110", VA = "0x311D110", Slot = "41")]
	private IDictionaryEnumerator System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6017B12")]
	[Address(RVA = "0x311D21C", Offset = "0x311D21C", VA = "0x311D21C", Slot = "42")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EInsert(int idx, object key, object value)
	{
	}

	[Token(Token = "0x6017B13")]
	[Address(RVA = "0x311D3E0", Offset = "0x311D3E0", VA = "0x311D3E0", Slot = "43")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002ERemoveAt(int idx)
	{
	}

	[Token(Token = "0x6017B14")]
	[Address(RVA = "0x3118AEC", Offset = "0x3118AEC", VA = "0x3118AEC")]
	private ICollection EnsureCollection()
	{
		return null;
	}

	[Token(Token = "0x6017B15")]
	[Address(RVA = "0x3118F7C", Offset = "0x3118F7C", VA = "0x3118F7C")]
	private IDictionary EnsureDictionary()
	{
		return null;
	}

	[Token(Token = "0x6017B16")]
	[Address(RVA = "0x3119CC8", Offset = "0x3119CC8", VA = "0x3119CC8")]
	private IList EnsureList()
	{
		return null;
	}

	[Token(Token = "0x6017B17")]
	[Address(RVA = "0x311A188", Offset = "0x311A188", VA = "0x311A188")]
	private JsonData ToJsonData(object obj)
	{
		return null;
	}

	[Token(Token = "0x6017B18")]
	[Address(RVA = "0x311D620", Offset = "0x311D620", VA = "0x311D620")]
	private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B19")]
	[Address(RVA = "0x311CA7C", Offset = "0x311CA7C", VA = "0x311CA7C")]
	public int Add(object value)
	{
		return default(int);
	}

	[Token(Token = "0x6017B1A")]
	[Address(RVA = "0x311F0D4", Offset = "0x311F0D4", VA = "0x311F0D4")]
	public bool Remove(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6017B1B")]
	[Address(RVA = "0x311F5FC", Offset = "0x311F5FC", VA = "0x311F5FC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6017B1C")]
	[Address(RVA = "0x311F73C", Offset = "0x311F73C", VA = "0x311F73C", Slot = "57")]
	public bool Equals(JsonData x)
	{
		return default(bool);
	}

	[Token(Token = "0x6017B1D")]
	[Address(RVA = "0x311F88C", Offset = "0x311F88C", VA = "0x311F88C", Slot = "14")]
	public JsonType GetJsonType()
	{
		return default(JsonType);
	}

	[Token(Token = "0x6017B1E")]
	[Address(RVA = "0x311F894", Offset = "0x311F894", VA = "0x311F894", Slot = "20")]
	public void SetJsonType(JsonType type)
	{
	}

	[Token(Token = "0x6017B1F")]
	[Address(RVA = "0x311C924", Offset = "0x311C924", VA = "0x311C924")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x6017B20")]
	[Address(RVA = "0x311CA0C", Offset = "0x311CA0C", VA = "0x311CA0C")]
	public void ToJson(JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B21")]
	[Address(RVA = "0x311FAE8", Offset = "0x311FAE8", VA = "0x311FAE8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
