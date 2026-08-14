using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E56")]
public class ModeVariableBinding
{
	[Token(Token = "0x2002E57")]
	private sealed class _003C_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011B48")]
		[FieldOffset(Offset = "0x8")]
		internal ModifierControlSkillCDByRegion modifier;

		[Token(Token = "0x601361F")]
		[Address(RVA = "0x22832E8", Offset = "0x22832E8", VA = "0x22832E8")]
		public _003C_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013620")]
		[Address(RVA = "0x22839CC", Offset = "0x22839CC", VA = "0x22839CC")]
		internal bool _003C_003Em__0(WorkShopSkillEditListData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011B43")]
	[FieldOffset(Offset = "0x8")]
	public ModeVariable Variable;

	[Token(Token = "0x4011B44")]
	[FieldOffset(Offset = "0xC")]
	public IModeVariableBindingModifier Modifier;

	[Token(Token = "0x4011B45")]
	[FieldOffset(Offset = "0x10")]
	private bool m_BoolValue;

	[Token(Token = "0x4011B46")]
	[FieldOffset(Offset = "0x14")]
	private int m_IntValue;

	[Token(Token = "0x4011B47")]
	[FieldOffset(Offset = "0x18")]
	private float m_FloatValue;

	[Token(Token = "0x17001415")]
	public bool BoolValue
	{
		[Token(Token = "0x6013616")]
		[Address(RVA = "0x2282F90", Offset = "0x2282F90", VA = "0x2282F90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013617")]
		[Address(RVA = "0x22832F0", Offset = "0x22832F0", VA = "0x22832F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001416")]
	public int IntValue
	{
		[Token(Token = "0x6013618")]
		[Address(RVA = "0x228336C", Offset = "0x228336C", VA = "0x228336C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6013619")]
		[Address(RVA = "0x2283568", Offset = "0x2283568", VA = "0x2283568")]
		set
		{
		}
	}

	[Token(Token = "0x17001417")]
	public float FloatValue
	{
		[Token(Token = "0x601361A")]
		[Address(RVA = "0x22835E4", Offset = "0x22835E4", VA = "0x22835E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601361B")]
		[Address(RVA = "0x2283654", Offset = "0x2283654", VA = "0x2283654")]
		set
		{
		}
	}

	[Token(Token = "0x6013615")]
	[Address(RVA = "0x2282F88", Offset = "0x2282F88", VA = "0x2282F88")]
	public ModeVariableBinding()
	{
	}

	[Token(Token = "0x601361C")]
	[Address(RVA = "0x22836D4", Offset = "0x22836D4", VA = "0x22836D4")]
	public void AddDataChanged(Action callback)
	{
	}

	[Token(Token = "0x601361D")]
	[Address(RVA = "0x228381C", Offset = "0x228381C", VA = "0x228381C")]
	public void RemoveDataChanged(Action callback)
	{
	}

	[Token(Token = "0x601361E")]
	[Address(RVA = "0x2283964", Offset = "0x2283964", VA = "0x2283964")]
	public void SaveValue()
	{
	}
}
