using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E54")]
public class ModeVariable
{
	[Token(Token = "0x2002E55")]
	public enum VariableType
	{
		[Token(Token = "0x4011B40")]
		Boolean,
		[Token(Token = "0x4011B41")]
		Int,
		[Token(Token = "0x4011B42")]
		Float
	}

	[Token(Token = "0x4011B2E")]
	[FieldOffset(Offset = "0x8")]
	public Action OnDataChanged;

	[Token(Token = "0x4011B2F")]
	[FieldOffset(Offset = "0xC")]
	public VariableType VarType;

	[Token(Token = "0x4011B30")]
	[FieldOffset(Offset = "0x10")]
	public int Id;

	[Token(Token = "0x4011B31")]
	[FieldOffset(Offset = "0x14")]
	public string Name;

	[Token(Token = "0x4011B32")]
	[FieldOffset(Offset = "0x18")]
	public string Rule;

	[Token(Token = "0x4011B33")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_BoolValue;

	[Token(Token = "0x4011B34")]
	[FieldOffset(Offset = "0x20")]
	private int m_IntValue;

	[Token(Token = "0x4011B35")]
	[FieldOffset(Offset = "0x24")]
	private float m_FloatValue;

	[Token(Token = "0x4011B36")]
	[FieldOffset(Offset = "0x28")]
	private bool BoolDefaultValue;

	[Token(Token = "0x4011B37")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, bool> BoolDefaultValueByMapIDs;

	[Token(Token = "0x4011B38")]
	[FieldOffset(Offset = "0x30")]
	private bool BoolSavedValue;

	[Token(Token = "0x4011B39")]
	[FieldOffset(Offset = "0x34")]
	private int IntDefaultValue;

	[Token(Token = "0x4011B3A")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, int> IntDefaultValueByMapIDs;

	[Token(Token = "0x4011B3B")]
	[FieldOffset(Offset = "0x3C")]
	private int IntSavedValue;

	[Token(Token = "0x4011B3C")]
	[FieldOffset(Offset = "0x40")]
	private float FloatDefaultValue;

	[Token(Token = "0x4011B3D")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, float> FloatDefaultValueByMapIDs;

	[Token(Token = "0x4011B3E")]
	[FieldOffset(Offset = "0x48")]
	private float FloatSavedValue;

	[Token(Token = "0x17001412")]
	public bool BoolValue
	{
		[Token(Token = "0x6013605")]
		[Address(RVA = "0x22819C8", Offset = "0x22819C8", VA = "0x22819C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013606")]
		[Address(RVA = "0x2281A20", Offset = "0x2281A20", VA = "0x2281A20")]
		set
		{
		}
	}

	[Token(Token = "0x17001413")]
	public int IntValue
	{
		[Token(Token = "0x6013607")]
		[Address(RVA = "0x2281AB0", Offset = "0x2281AB0", VA = "0x2281AB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6013608")]
		[Address(RVA = "0x2281B08", Offset = "0x2281B08", VA = "0x2281B08")]
		set
		{
		}
	}

	[Token(Token = "0x17001414")]
	public float FloatValue
	{
		[Token(Token = "0x6013609")]
		[Address(RVA = "0x2281B9C", Offset = "0x2281B9C", VA = "0x2281B9C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601360A")]
		[Address(RVA = "0x2281BF4", Offset = "0x2281BF4", VA = "0x2281BF4")]
		set
		{
		}
	}

	[Token(Token = "0x6013604")]
	[Address(RVA = "0x22819B8", Offset = "0x22819B8", VA = "0x22819B8")]
	public ModeVariable()
	{
	}

	[Token(Token = "0x601360B")]
	[Address(RVA = "0x2281D24", Offset = "0x2281D24", VA = "0x2281D24")]
	public bool ReadDefaultFromJson(JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x601360C")]
	[Address(RVA = "0x2282674", Offset = "0x2282674", VA = "0x2282674")]
	public bool GetBoolDefaultValue(uint mapID)
	{
		return default(bool);
	}

	[Token(Token = "0x601360D")]
	[Address(RVA = "0x2282764", Offset = "0x2282764", VA = "0x2282764")]
	public int GetIntDefaultValue(uint mapID)
	{
		return default(int);
	}

	[Token(Token = "0x601360E")]
	[Address(RVA = "0x228284C", Offset = "0x228284C", VA = "0x228284C")]
	public float GetFloatDefaultValue(uint mapID)
	{
		return default(float);
	}

	[Token(Token = "0x601360F")]
	[Address(RVA = "0x228293C", Offset = "0x228293C", VA = "0x228293C")]
	public void ResetToDefault(uint mapID)
	{
	}

	[Token(Token = "0x6013610")]
	[Address(RVA = "0x2282A08", Offset = "0x2282A08", VA = "0x2282A08")]
	public void ResetToSaved()
	{
	}

	[Token(Token = "0x6013611")]
	[Address(RVA = "0x2282AA8", Offset = "0x2282AA8", VA = "0x2282AA8")]
	public void Save()
	{
	}

	[Token(Token = "0x6013612")]
	[Address(RVA = "0x2282B48", Offset = "0x2282B48", VA = "0x2282B48")]
	public string ValueToString()
	{
		return null;
	}

	[Token(Token = "0x6013613")]
	[Address(RVA = "0x2282CA8", Offset = "0x2282CA8", VA = "0x2282CA8")]
	public string AllValuesToString()
	{
		return null;
	}

	[Token(Token = "0x6013614")]
	[Address(RVA = "0x2282E20", Offset = "0x2282E20", VA = "0x2282E20")]
	public void CopyFrom(ModeVariable variable)
	{
	}
}
