using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032E3")]
public class NewBieGuildBasProcessor
{
	[Token(Token = "0x20032E4")]
	public class NewBieGuideCondition
	{
		[Token(Token = "0x40135C2")]
		[FieldOffset(Offset = "0x8")]
		public int precdt1;

		[Token(Token = "0x40135C3")]
		[FieldOffset(Offset = "0xC")]
		public int value1;

		[Token(Token = "0x40135C4")]
		[FieldOffset(Offset = "0x10")]
		public int precdt2;

		[Token(Token = "0x40135C5")]
		[FieldOffset(Offset = "0x14")]
		public int value2;

		[Token(Token = "0x40135C6")]
		[FieldOffset(Offset = "0x18")]
		public int precdt3;

		[Token(Token = "0x40135C7")]
		[FieldOffset(Offset = "0x1C")]
		public int value3;

		[Token(Token = "0x40135C8")]
		[FieldOffset(Offset = "0x20")]
		public int precdt4;

		[Token(Token = "0x40135C9")]
		[FieldOffset(Offset = "0x24")]
		public int value4;

		[Token(Token = "0x6015739")]
		[Address(RVA = "0x22950E4", Offset = "0x22950E4", VA = "0x22950E4")]
		public NewBieGuideCondition()
		{
		}

		[Token(Token = "0x601573A")]
		[Address(RVA = "0x22950EC", Offset = "0x22950EC", VA = "0x22950EC")]
		public void SetGuideVal(int pre1, int val1, int pre2, int val2, int pre3, int val3, int pre4, int val4)
		{
		}
	}

	[Token(Token = "0x40135BC")]
	[FieldOffset(Offset = "0x8")]
	protected NewbieGuideId m_newbieid;

	[Token(Token = "0x40135BD")]
	[FieldOffset(Offset = "0xC")]
	public uint m_prority;

	[Token(Token = "0x40135BE")]
	[FieldOffset(Offset = "0x10")]
	protected string m_newbieguidekey;

	[Token(Token = "0x40135BF")]
	[FieldOffset(Offset = "0x14")]
	protected List<NewBieGuideCondition> m_ConditionList;

	[Token(Token = "0x40135C0")]
	[FieldOffset(Offset = "0x18")]
	public UICommonGuideController m_NewbieGuideCtrl;

	[Token(Token = "0x40135C1")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget m_HandPoint;

	[Token(Token = "0x601572F")]
	[Address(RVA = "0x2293B58", Offset = "0x2293B58", VA = "0x2293B58")]
	public NewBieGuildBasProcessor()
	{
	}

	[Token(Token = "0x6015730")]
	[Address(RVA = "0x2294CAC", Offset = "0x2294CAC", VA = "0x2294CAC")]
	public NewbieGuideId GetNewBieGuideId()
	{
		return default(NewbieGuideId);
	}

	[Token(Token = "0x6015731")]
	[Address(RVA = "0x2294D04", Offset = "0x2294D04", VA = "0x2294D04")]
	public void SetHandWidget(UIWidget wd)
	{
	}

	[Token(Token = "0x6015732")]
	[Address(RVA = "0x2294D64", Offset = "0x2294D64", VA = "0x2294D64")]
	public void ClearHandWidget()
	{
	}

	[Token(Token = "0x6015733")]
	[Address(RVA = "0x2294DC0", Offset = "0x2294DC0", VA = "0x2294DC0", Slot = "4")]
	public virtual void NewBieGuideInit()
	{
	}

	[Token(Token = "0x6015734")]
	[Address(RVA = "0x22951B4", Offset = "0x22951B4", VA = "0x22951B4", Slot = "5")]
	public virtual bool CheckCanGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x6015735")]
	[Address(RVA = "0x22954E4", Offset = "0x22954E4", VA = "0x22954E4")]
	private bool CheckGuideCondition(int condinum, int valuenum)
	{
		return default(bool);
	}

	[Token(Token = "0x6015736")]
	[Address(RVA = "0x22956BC", Offset = "0x22956BC", VA = "0x22956BC")]
	public void FinishGuide()
	{
	}

	[Token(Token = "0x6015737")]
	[Address(RVA = "0x2294324", Offset = "0x2294324", VA = "0x2294324", Slot = "6")]
	public virtual void DoGuild()
	{
	}

	[Token(Token = "0x6015738")]
	[Address(RVA = "0x229448C", Offset = "0x229448C", VA = "0x229448C", Slot = "7")]
	public virtual void CloseGuild()
	{
	}
}
