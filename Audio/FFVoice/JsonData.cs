using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B46")]
public class JsonData : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable, IEquatable<long>, IConvertible
{
	[Token(Token = "0x40193F2")]
	[FieldOffset(Offset = "0x8")]
	private IList<JsonData> inst_array;

	[Token(Token = "0x40193F3")]
	[FieldOffset(Offset = "0xC")]
	private bool inst_boolean;

	[Token(Token = "0x40193F4")]
	[FieldOffset(Offset = "0x10")]
	private double inst_double;

	[Token(Token = "0x40193F5")]
	[FieldOffset(Offset = "0x18")]
	private int inst_int;

	[Token(Token = "0x40193F6")]
	[FieldOffset(Offset = "0x20")]
	private long inst_long;

	[Token(Token = "0x40193F7")]
	[FieldOffset(Offset = "0x28")]
	private IDictionary<string, JsonData> inst_object;

	[Token(Token = "0x40193F8")]
	[FieldOffset(Offset = "0x2C")]
	private string inst_string;

	[Token(Token = "0x40193F9")]
	[FieldOffset(Offset = "0x30")]
	private string json;

	[Token(Token = "0x40193FA")]
	[FieldOffset(Offset = "0x34")]
	private JsonType type;

	[Token(Token = "0x40193FB")]
	[FieldOffset(Offset = "0x38")]
	private IList<KeyValuePair<string, JsonData>> object_list;

	[Token(Token = "0x170017DA")]
	private int System_002ECollections_002EICollection_002ECount
	{
		[Token(Token = "0x60178E6")]
		[Address(RVA = "0x321959C", Offset = "0x321959C", VA = "0x321959C", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170017DB")]
	private bool System_002ECollections_002EICollection_002EIsSynchronized
	{
		[Token(Token = "0x60178E7")]
		[Address(RVA = "0x32195A0", Offset = "0x32195A0", VA = "0x32195A0", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DC")]
	private object System_002ECollections_002EICollection_002ESyncRoot
	{
		[Token(Token = "0x60178E8")]
		[Address(RVA = "0x3219680", Offset = "0x3219680", VA = "0x3219680", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017DD")]
	private bool System_002ECollections_002EIDictionary_002EIsFixedSize
	{
		[Token(Token = "0x60178E9")]
		[Address(RVA = "0x3219760", Offset = "0x3219760", VA = "0x3219760", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DE")]
	private bool System_002ECollections_002EIDictionary_002EIsReadOnly
	{
		[Token(Token = "0x60178EA")]
		[Address(RVA = "0x3219840", Offset = "0x3219840", VA = "0x3219840", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DF")]
	private ICollection System_002ECollections_002EIDictionary_002EKeys
	{
		[Token(Token = "0x60178EB")]
		[Address(RVA = "0x3219920", Offset = "0x3219920", VA = "0x3219920", Slot = "50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017E0")]
	private ICollection System_002ECollections_002EIDictionary_002EValues
	{
		[Token(Token = "0x60178EC")]
		[Address(RVA = "0x3219DBC", Offset = "0x3219DBC", VA = "0x3219DBC", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017E1")]
	private bool FFVoice_002EIJsonWrapper_002EIsArray
	{
		[Token(Token = "0x60178ED")]
		[Address(RVA = "0x321A258", Offset = "0x321A258", VA = "0x321A258", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E2")]
	private bool FFVoice_002EIJsonWrapper_002EIsBoolean
	{
		[Token(Token = "0x60178EE")]
		[Address(RVA = "0x321A26C", Offset = "0x321A26C", VA = "0x321A26C", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E3")]
	private bool FFVoice_002EIJsonWrapper_002EIsDouble
	{
		[Token(Token = "0x60178EF")]
		[Address(RVA = "0x321A280", Offset = "0x321A280", VA = "0x321A280", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E4")]
	private bool FFVoice_002EIJsonWrapper_002EIsInt
	{
		[Token(Token = "0x60178F0")]
		[Address(RVA = "0x321A294", Offset = "0x321A294", VA = "0x321A294", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E5")]
	private bool FFVoice_002EIJsonWrapper_002EIsLong
	{
		[Token(Token = "0x60178F1")]
		[Address(RVA = "0x321A2A8", Offset = "0x321A2A8", VA = "0x321A2A8", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E6")]
	private bool FFVoice_002EIJsonWrapper_002EIsObject
	{
		[Token(Token = "0x60178F2")]
		[Address(RVA = "0x321A2BC", Offset = "0x321A2BC", VA = "0x321A2BC", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E7")]
	private bool FFVoice_002EIJsonWrapper_002EIsString
	{
		[Token(Token = "0x60178F3")]
		[Address(RVA = "0x321A2CC", Offset = "0x321A2CC", VA = "0x321A2CC", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E8")]
	private bool System_002ECollections_002EIList_002EIsFixedSize
	{
		[Token(Token = "0x60178F4")]
		[Address(RVA = "0x321A2E0", Offset = "0x321A2E0", VA = "0x321A2E0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E9")]
	private bool System_002ECollections_002EIList_002EIsReadOnly
	{
		[Token(Token = "0x60178F5")]
		[Address(RVA = "0x321A558", Offset = "0x321A558", VA = "0x321A558", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017EA")]
	private object System_002ECollections_002EIDictionary_002EItem
	{
		[Token(Token = "0x60178F6")]
		[Address(RVA = "0x321A638", Offset = "0x321A638", VA = "0x321A638", Slot = "48")]
		get
		{
			return null;
		}
		[Token(Token = "0x60178F7")]
		[Address(RVA = "0x321A720", Offset = "0x321A720", VA = "0x321A720", Slot = "49")]
		set
		{
		}
	}

	[Token(Token = "0x170017EB")]
	private object System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EItem
	{
		[Token(Token = "0x60178F8")]
		[Address(RVA = "0x321AE14", Offset = "0x321AE14", VA = "0x321AE14", Slot = "44")]
		get
		{
			return null;
		}
		[Token(Token = "0x60178F9")]
		[Address(RVA = "0x321AF30", Offset = "0x321AF30", VA = "0x321AF30", Slot = "45")]
		set
		{
		}
	}

	[Token(Token = "0x170017EC")]
	private object System_002ECollections_002EIList_002EItem
	{
		[Token(Token = "0x60178FA")]
		[Address(RVA = "0x321B1DC", Offset = "0x321B1DC", VA = "0x321B1DC", Slot = "27")]
		get
		{
			return null;
		}
		[Token(Token = "0x60178FB")]
		[Address(RVA = "0x321B2C4", Offset = "0x321B2C4", VA = "0x321B2C4", Slot = "28")]
		set
		{
		}
	}

	[Token(Token = "0x170017ED")]
	public int Count
	{
		[Token(Token = "0x60178DD")]
		[Address(RVA = "0x3219024", Offset = "0x3219024", VA = "0x3219024")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170017EE")]
	public bool IsArray
	{
		[Token(Token = "0x60178DE")]
		[Address(RVA = "0x3219268", Offset = "0x3219268", VA = "0x3219268")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017EF")]
	public bool IsBoolean
	{
		[Token(Token = "0x60178DF")]
		[Address(RVA = "0x321927C", Offset = "0x321927C", VA = "0x321927C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017F0")]
	public bool IsDouble
	{
		[Token(Token = "0x60178E0")]
		[Address(RVA = "0x3219290", Offset = "0x3219290", VA = "0x3219290")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017F1")]
	public bool IsInt
	{
		[Token(Token = "0x60178E1")]
		[Address(RVA = "0x32192A4", Offset = "0x32192A4", VA = "0x32192A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017F2")]
	public bool IsLong
	{
		[Token(Token = "0x60178E2")]
		[Address(RVA = "0x32192B8", Offset = "0x32192B8", VA = "0x32192B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017F3")]
	public bool IsObject
	{
		[Token(Token = "0x60178E3")]
		[Address(RVA = "0x32192CC", Offset = "0x32192CC", VA = "0x32192CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017F4")]
	public bool IsString
	{
		[Token(Token = "0x60178E4")]
		[Address(RVA = "0x32192DC", Offset = "0x32192DC", VA = "0x32192DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017F5")]
	public ICollection<string> Keys
	{
		[Token(Token = "0x60178E5")]
		[Address(RVA = "0x32192F0", Offset = "0x32192F0", VA = "0x32192F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017F6")]
	public JsonData Item
	{
		[Token(Token = "0x60178FC")]
		[Address(RVA = "0x32142EC", Offset = "0x32142EC", VA = "0x32142EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60178FD")]
		[Address(RVA = "0x321A930", Offset = "0x321A930", VA = "0x321A930")]
		set
		{
		}
	}

	[Token(Token = "0x170017F7")]
	public JsonData Item
	{
		[Token(Token = "0x60178FE")]
		[Address(RVA = "0x321B644", Offset = "0x321B644", VA = "0x321B644")]
		get
		{
			return null;
		}
		[Token(Token = "0x60178FF")]
		[Address(RVA = "0x321B2F8", Offset = "0x321B2F8", VA = "0x321B2F8")]
		set
		{
		}
	}

	[Token(Token = "0x60178D6")]
	[Address(RVA = "0x3218D20", Offset = "0x3218D20", VA = "0x3218D20")]
	public JsonData()
	{
	}

	[Token(Token = "0x60178D7")]
	[Address(RVA = "0x3218D28", Offset = "0x3218D28", VA = "0x3218D28")]
	public JsonData(bool boolean)
	{
	}

	[Token(Token = "0x60178D8")]
	[Address(RVA = "0x3218D50", Offset = "0x3218D50", VA = "0x3218D50")]
	public JsonData(double number)
	{
	}

	[Token(Token = "0x60178D9")]
	[Address(RVA = "0x3218D80", Offset = "0x3218D80", VA = "0x3218D80")]
	public JsonData(int number)
	{
	}

	[Token(Token = "0x60178DA")]
	[Address(RVA = "0x3218DA8", Offset = "0x3218DA8", VA = "0x3218DA8")]
	public JsonData(long number)
	{
	}

	[Token(Token = "0x60178DB")]
	[Address(RVA = "0x3218DD8", Offset = "0x3218DD8", VA = "0x3218DD8")]
	public JsonData(object obj)
	{
	}

	[Token(Token = "0x60178DC")]
	[Address(RVA = "0x3218FFC", Offset = "0x3218FFC", VA = "0x3218FFC")]
	public JsonData(string str)
	{
	}

	[Token(Token = "0x6017900")]
	[Address(RVA = "0x321B800", Offset = "0x321B800", VA = "0x321B800")]
	public static implicit operator JsonData(bool data)
	{
		return null;
	}

	[Token(Token = "0x6017901")]
	[Address(RVA = "0x321B87C", Offset = "0x321B87C", VA = "0x321B87C")]
	public static implicit operator JsonData(double data)
	{
		return null;
	}

	[Token(Token = "0x6017902")]
	[Address(RVA = "0x321B900", Offset = "0x321B900", VA = "0x321B900")]
	public static implicit operator JsonData(int data)
	{
		return null;
	}

	[Token(Token = "0x6017903")]
	[Address(RVA = "0x321B97C", Offset = "0x321B97C", VA = "0x321B97C")]
	public static implicit operator JsonData(long data)
	{
		return null;
	}

	[Token(Token = "0x6017904")]
	[Address(RVA = "0x321BA00", Offset = "0x321BA00", VA = "0x321BA00")]
	public static implicit operator JsonData(string data)
	{
		return null;
	}

	[Token(Token = "0x6017905")]
	[Address(RVA = "0x321BA7C", Offset = "0x321BA7C", VA = "0x321BA7C")]
	public static explicit operator bool(JsonData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6017906")]
	[Address(RVA = "0x321BB3C", Offset = "0x321BB3C", VA = "0x321BB3C")]
	public static explicit operator double(JsonData data)
	{
		return default(double);
	}

	[Token(Token = "0x6017907")]
	[Address(RVA = "0x32143D4", Offset = "0x32143D4", VA = "0x32143D4")]
	public static explicit operator int(JsonData data)
	{
		return default(int);
	}

	[Token(Token = "0x6017908")]
	[Address(RVA = "0x321BC00", Offset = "0x321BC00", VA = "0x321BC00")]
	public static explicit operator long(JsonData data)
	{
		return default(long);
	}

	[Token(Token = "0x6017909")]
	[Address(RVA = "0x3214494", Offset = "0x3214494", VA = "0x3214494")]
	public static explicit operator string(JsonData data)
	{
		return null;
	}

	[Token(Token = "0x601790A")]
	[Address(RVA = "0x321BCC0", Offset = "0x321BCC0", VA = "0x321BCC0", Slot = "40")]
	private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
	{
	}

	[Token(Token = "0x601790B")]
	[Address(RVA = "0x321BDB0", Offset = "0x321BDB0", VA = "0x321BDB0", Slot = "52")]
	private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
	{
	}

	[Token(Token = "0x601790C")]
	[Address(RVA = "0x321BFFC", Offset = "0x321BFFC", VA = "0x321BFFC", Slot = "53")]
	private void System_002ECollections_002EIDictionary_002EClear()
	{
	}

	[Token(Token = "0x601790D")]
	[Address(RVA = "0x321C170", Offset = "0x321C170", VA = "0x321C170", Slot = "54")]
	private bool System_002ECollections_002EIDictionary_002EContains(object key)
	{
		return default(bool);
	}

	[Token(Token = "0x601790E")]
	[Address(RVA = "0x321C258", Offset = "0x321C258", VA = "0x321C258", Slot = "55")]
	private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x601790F")]
	[Address(RVA = "0x321C31C", Offset = "0x321C31C", VA = "0x321C31C", Slot = "56")]
	private void System_002ECollections_002EIDictionary_002ERemove(object key)
	{
	}

	[Token(Token = "0x6017910")]
	[Address(RVA = "0x321C6FC", Offset = "0x321C6FC", VA = "0x321C6FC", Slot = "36")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6017911")]
	[Address(RVA = "0x321C7DC", Offset = "0x321C7DC", VA = "0x321C7DC", Slot = "11")]
	private bool FFVoice_002EIJsonWrapper_002EGetBoolean()
	{
		return default(bool);
	}

	[Token(Token = "0x6017912")]
	[Address(RVA = "0x321C88C", Offset = "0x321C88C", VA = "0x321C88C", Slot = "12")]
	private double FFVoice_002EIJsonWrapper_002EGetDouble()
	{
		return default(double);
	}

	[Token(Token = "0x6017913")]
	[Address(RVA = "0x321C940", Offset = "0x321C940", VA = "0x321C940", Slot = "13")]
	private int FFVoice_002EIJsonWrapper_002EGetInt()
	{
		return default(int);
	}

	[Token(Token = "0x6017914")]
	[Address(RVA = "0x321C9F0", Offset = "0x321C9F0", VA = "0x321C9F0", Slot = "15")]
	private long FFVoice_002EIJsonWrapper_002EGetLong()
	{
		return default(long);
	}

	[Token(Token = "0x6017915")]
	[Address(RVA = "0x321CAA0", Offset = "0x321CAA0", VA = "0x321CAA0", Slot = "16")]
	private string FFVoice_002EIJsonWrapper_002EGetString()
	{
		return null;
	}

	[Token(Token = "0x6017916")]
	[Address(RVA = "0x321CB50", Offset = "0x321CB50", VA = "0x321CB50", Slot = "17")]
	private void FFVoice_002EIJsonWrapper_002ESetBoolean(bool val)
	{
	}

	[Token(Token = "0x6017917")]
	[Address(RVA = "0x321CB68", Offset = "0x321CB68", VA = "0x321CB68", Slot = "18")]
	private void FFVoice_002EIJsonWrapper_002ESetDouble(double val)
	{
	}

	[Token(Token = "0x6017918")]
	[Address(RVA = "0x321CB88", Offset = "0x321CB88", VA = "0x321CB88", Slot = "19")]
	private void FFVoice_002EIJsonWrapper_002ESetInt(int val)
	{
	}

	[Token(Token = "0x6017919")]
	[Address(RVA = "0x321CBA0", Offset = "0x321CBA0", VA = "0x321CBA0", Slot = "21")]
	private void FFVoice_002EIJsonWrapper_002ESetLong(long val)
	{
	}

	[Token(Token = "0x601791A")]
	[Address(RVA = "0x321CBC0", Offset = "0x321CBC0", VA = "0x321CBC0", Slot = "22")]
	private void FFVoice_002EIJsonWrapper_002ESetString(string val)
	{
	}

	[Token(Token = "0x601791B")]
	[Address(RVA = "0x321CBD8", Offset = "0x321CBD8", VA = "0x321CBD8", Slot = "23")]
	private string FFVoice_002EIJsonWrapper_002EToJson()
	{
		return null;
	}

	[Token(Token = "0x601791C")]
	[Address(RVA = "0x321CCCC", Offset = "0x321CCCC", VA = "0x321CCCC", Slot = "24")]
	private void FFVoice_002EIJsonWrapper_002EToJson(JsonWriter writer)
	{
	}

	[Token(Token = "0x601791D")]
	[Address(RVA = "0x321CD5C", Offset = "0x321CD5C", VA = "0x321CD5C", Slot = "29")]
	private int System_002ECollections_002EIList_002EAdd(object value)
	{
		return default(int);
	}

	[Token(Token = "0x601791E")]
	[Address(RVA = "0x321CE5C", Offset = "0x321CE5C", VA = "0x321CE5C", Slot = "30")]
	private void System_002ECollections_002EIList_002EClear()
	{
	}

	[Token(Token = "0x601791F")]
	[Address(RVA = "0x321CF44", Offset = "0x321CF44", VA = "0x321CF44", Slot = "31")]
	private bool System_002ECollections_002EIList_002EContains(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6017920")]
	[Address(RVA = "0x321D02C", Offset = "0x321D02C", VA = "0x321D02C", Slot = "32")]
	private int System_002ECollections_002EIList_002EIndexOf(object value)
	{
		return default(int);
	}

	[Token(Token = "0x6017921")]
	[Address(RVA = "0x321D114", Offset = "0x321D114", VA = "0x321D114", Slot = "33")]
	private void System_002ECollections_002EIList_002EInsert(int index, object value)
	{
	}

	[Token(Token = "0x6017922")]
	[Address(RVA = "0x321D214", Offset = "0x321D214", VA = "0x321D214", Slot = "34")]
	private void System_002ECollections_002EIList_002ERemove(object value)
	{
	}

	[Token(Token = "0x6017923")]
	[Address(RVA = "0x321D304", Offset = "0x321D304", VA = "0x321D304", Slot = "35")]
	private void System_002ECollections_002EIList_002ERemoveAt(int index)
	{
	}

	[Token(Token = "0x6017924")]
	[Address(RVA = "0x321D3F4", Offset = "0x321D3F4", VA = "0x321D3F4", Slot = "41")]
	private IDictionaryEnumerator System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6017925")]
	[Address(RVA = "0x321D500", Offset = "0x321D500", VA = "0x321D500", Slot = "42")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EInsert(int idx, object key, object value)
	{
	}

	[Token(Token = "0x6017926")]
	[Address(RVA = "0x321D6C4", Offset = "0x321D6C4", VA = "0x321D6C4", Slot = "43")]
	private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002ERemoveAt(int idx)
	{
	}

	[Token(Token = "0x6017927")]
	[Address(RVA = "0x3219104", Offset = "0x3219104", VA = "0x3219104")]
	private ICollection EnsureCollection()
	{
		return null;
	}

	[Token(Token = "0x6017928")]
	[Address(RVA = "0x32193D0", Offset = "0x32193D0", VA = "0x32193D0")]
	private IDictionary EnsureDictionary()
	{
		return null;
	}

	[Token(Token = "0x6017929")]
	[Address(RVA = "0x321A3C0", Offset = "0x321A3C0", VA = "0x321A3C0")]
	private IList EnsureList()
	{
		return null;
	}

	[Token(Token = "0x601792A")]
	[Address(RVA = "0x321A880", Offset = "0x321A880", VA = "0x321A880")]
	private JsonData ToJsonData(object obj)
	{
		return null;
	}

	[Token(Token = "0x601792B")]
	[Address(RVA = "0x321D904", Offset = "0x321D904", VA = "0x321D904")]
	private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x601792C")]
	[Address(RVA = "0x321CD60", Offset = "0x321CD60", VA = "0x321CD60")]
	public int Add(object value)
	{
		return default(int);
	}

	[Token(Token = "0x601792D")]
	[Address(RVA = "0x321E820", Offset = "0x321E820", VA = "0x321E820")]
	public void Clear()
	{
	}

	[Token(Token = "0x601792E")]
	[Address(RVA = "0x321E960", Offset = "0x321E960", VA = "0x321E960", Slot = "57")]
	public bool Equals(JsonData x)
	{
		return default(bool);
	}

	[Token(Token = "0x601792F")]
	[Address(RVA = "0x321EAB0", Offset = "0x321EAB0", VA = "0x321EAB0", Slot = "14")]
	public JsonType GetJsonType()
	{
		return default(JsonType);
	}

	[Token(Token = "0x6017930")]
	[Address(RVA = "0x321EAB8", Offset = "0x321EAB8", VA = "0x321EAB8", Slot = "20")]
	public void SetJsonType(JsonType type)
	{
	}

	[Token(Token = "0x6017931")]
	[Address(RVA = "0x321CBDC", Offset = "0x321CBDC", VA = "0x321CBDC")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x6017932")]
	[Address(RVA = "0x321CCD0", Offset = "0x321CCD0", VA = "0x321CCD0")]
	public void ToJson(JsonWriter writer)
	{
	}

	[Token(Token = "0x6017933")]
	[Address(RVA = "0x321EC34", Offset = "0x321EC34", VA = "0x321EC34", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
