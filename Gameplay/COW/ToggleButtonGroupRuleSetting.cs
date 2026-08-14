using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2003291")]
public class ToggleButtonGroupRuleSetting : _Attribute
{
	[Serializable]
	[Token(Token = "0x2003292")]
	public class Item
	{
		[Token(Token = "0x401342A")]
		[FieldOffset(Offset = "0x8")]
		public string LabelID;

		[Token(Token = "0x401342B")]
		[FieldOffset(Offset = "0xC")]
		public int Value;

		[Token(Token = "0x6015539")]
		[Address(RVA = "0x28ADC90", Offset = "0x28ADC90", VA = "0x28ADC90")]
		public Item()
		{
		}
	}

	[Token(Token = "0x2003293")]
	private sealed class _003CFromProtoData_003Ec__AnonStorey0
	{
		[Token(Token = "0x401342C")]
		[FieldOffset(Offset = "0x8")]
		internal int value;

		[Token(Token = "0x601553A")]
		[Address(RVA = "0x28AD958", Offset = "0x28AD958", VA = "0x28AD958")]
		public _003CFromProtoData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601553B")]
		[Address(RVA = "0x28ADCD0", Offset = "0x28ADCD0", VA = "0x28ADCD0")]
		internal bool _003C_003Em__0(Item item)
		{
			return default(bool);
		}
	}

	[NonSerialized]
	[Token(Token = "0x4013421")]
	[FieldOffset(Offset = "0x8")]
	public int Value;

	[NonSerialized]
	[Token(Token = "0x4013422")]
	[FieldOffset(Offset = "0xC")]
	public bool Enabled;

	[Token(Token = "0x4013423")]
	[FieldOffset(Offset = "0x10")]
	public string TitleID;

	[Token(Token = "0x4013424")]
	[FieldOffset(Offset = "0x14")]
	public Item[] Items;

	[Token(Token = "0x4013425")]
	[FieldOffset(Offset = "0x18")]
	public int DefaultValue;

	[Token(Token = "0x4013426")]
	[FieldOffset(Offset = "0x1C")]
	public int Column;

	[Token(Token = "0x4013427")]
	[FieldOffset(Offset = "0x20")]
	public int MinBGHeight;

	[Token(Token = "0x4013428")]
	[FieldOffset(Offset = "0x24")]
	public int StepWidth;

	[Token(Token = "0x4013429")]
	[FieldOffset(Offset = "0x28")]
	public int StepHeight;

	[Token(Token = "0x6015533")]
	[Address(RVA = "0x28AD580", Offset = "0x28AD580", VA = "0x28AD580")]
	public ToggleButtonGroupRuleSetting()
	{
	}

	[Token(Token = "0x6015534")]
	[Address(RVA = "0x28AD588", Offset = "0x28AD588", VA = "0x28AD588")]
	public int ToProtoData()
	{
		return default(int);
	}

	[Token(Token = "0x6015535")]
	[Address(RVA = "0x28AD750", Offset = "0x28AD750", VA = "0x28AD750")]
	public bool FromProtoData(int value)
	{
		return default(bool);
	}

	[Token(Token = "0x6015536")]
	[Address(RVA = "0x28AD960", Offset = "0x28AD960", VA = "0x28AD960")]
	public void FromDefaultData()
	{
	}

	[Token(Token = "0x6015537")]
	[Address(RVA = "0x28AD9BC", Offset = "0x28AD9BC", VA = "0x28AD9BC")]
	public ToggleButtonGroupRuleSetting Clone()
	{
		return null;
	}

	[Token(Token = "0x6015538")]
	[Address(RVA = "0x28ADC98", Offset = "0x28ADC98", VA = "0x28ADC98")]
	private bool _003CToProtoData_003Em__0(Item item)
	{
		return default(bool);
	}
}
