using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E3F")]
public class GachaInfoDataBase
{
	[Token(Token = "0x4011AE1")]
	[FieldOffset(Offset = "0x8")]
	public uint GachaID;

	[Token(Token = "0x4011AE2")]
	[FieldOffset(Offset = "0xC")]
	private GachaInfo _003CGachaInfo_003Ek__BackingField;

	[Token(Token = "0x4011AE3")]
	[FieldOffset(Offset = "0x10")]
	private CompletionBackpackInfo _003CBagPackInfo_003Ek__BackingField;

	[Token(Token = "0x4011AE4")]
	[FieldOffset(Offset = "0x14")]
	private GachaDesc _003CGachaDesc_003Ek__BackingField;

	[Token(Token = "0x4011AE5")]
	[FieldOffset(Offset = "0x18")]
	private ClientChestType _003CChestType_003Ek__BackingField;

	[Token(Token = "0x4011AE6")]
	[FieldOffset(Offset = "0x1C")]
	private List<uint> _003CAvatarList_003Ek__BackingField;

	[Token(Token = "0x4011AE7")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, List<GachaShowItem>> _003CRewardsPoolListDic_003Ek__BackingField;

	[Token(Token = "0x170013FE")]
	public GachaInfo GachaInfo
	{
		[Token(Token = "0x601356F")]
		[Address(RVA = "0x1052228", Offset = "0x1052228", VA = "0x1052228")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013570")]
		[Address(RVA = "0x1052230", Offset = "0x1052230", VA = "0x1052230")]
		protected set
		{
		}
	}

	[Token(Token = "0x170013FF")]
	public CompletionBackpackInfo BagPackInfo
	{
		[Token(Token = "0x6013571")]
		[Address(RVA = "0x1052238", Offset = "0x1052238", VA = "0x1052238")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013572")]
		[Address(RVA = "0x1052240", Offset = "0x1052240", VA = "0x1052240")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001400")]
	public GachaDesc GachaDesc
	{
		[Token(Token = "0x6013573")]
		[Address(RVA = "0x1052248", Offset = "0x1052248", VA = "0x1052248")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013574")]
		[Address(RVA = "0x1052250", Offset = "0x1052250", VA = "0x1052250")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001401")]
	public ClientChestType ChestType
	{
		[Token(Token = "0x6013575")]
		[Address(RVA = "0x1052258", Offset = "0x1052258", VA = "0x1052258")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013576")]
		[Address(RVA = "0x1052260", Offset = "0x1052260", VA = "0x1052260")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001402")]
	public List<uint> AvatarList
	{
		[Token(Token = "0x6013577")]
		[Address(RVA = "0x1052268", Offset = "0x1052268", VA = "0x1052268")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013578")]
		[Address(RVA = "0x1052270", Offset = "0x1052270", VA = "0x1052270")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001403")]
	public Dictionary<uint, List<GachaShowItem>> RewardsPoolListDic
	{
		[Token(Token = "0x6013579")]
		[Address(RVA = "0x1052278", Offset = "0x1052278", VA = "0x1052278")]
		get
		{
			return null;
		}
		[Token(Token = "0x601357A")]
		[Address(RVA = "0x1052220", Offset = "0x1052220", VA = "0x1052220")]
		protected set
		{
		}
	}

	[Token(Token = "0x601356E")]
	[Address(RVA = "0x1052194", Offset = "0x1052194", VA = "0x1052194")]
	public GachaInfoDataBase()
	{
	}

	[Token(Token = "0x601357B")]
	[Address(RVA = "0x1052280", Offset = "0x1052280", VA = "0x1052280")]
	public void ProcessInfoData(GachaInfo gachaInfo)
	{
	}

	[Token(Token = "0x601357C")]
	[Address(RVA = "0x105230C", Offset = "0x105230C", VA = "0x105230C")]
	public void ProcessBagPackData(CompletionBackpackInfo data)
	{
	}

	[Token(Token = "0x601357D")]
	[Address(RVA = "0x1052398", Offset = "0x1052398", VA = "0x1052398", Slot = "4")]
	protected virtual void OnUpdateInfoData()
	{
	}

	[Token(Token = "0x601357E")]
	[Address(RVA = "0x10523EC", Offset = "0x10523EC", VA = "0x10523EC", Slot = "5")]
	protected virtual void OnUpdateBagPackData()
	{
	}

	[Token(Token = "0x601357F")]
	[Address(RVA = "0x1052440", Offset = "0x1052440", VA = "0x1052440", Slot = "6")]
	public virtual void UpdateByGachaResult(CSLotteryRes gachaResult)
	{
	}

	[Token(Token = "0x6013580")]
	[Address(RVA = "0x1052548", Offset = "0x1052548", VA = "0x1052548")]
	private void UpdateExtraListCurCount(uint curCount)
	{
	}

	[Token(Token = "0x6013581")]
	[Address(RVA = "0x10525B4", Offset = "0x10525B4", VA = "0x10525B4")]
	protected void ComposeExtraDesc(GachaDesc desc)
	{
	}

	[Token(Token = "0x6013582")]
	[Address(RVA = "0x105271C", Offset = "0x105271C", VA = "0x105271C")]
	protected void ComposeShowReward(GachaDesc desc)
	{
	}

	[Token(Token = "0x6013583")]
	[Address(RVA = "0x1052BA4", Offset = "0x1052BA4", VA = "0x1052BA4")]
	public void ClearInfoData()
	{
	}

	[Token(Token = "0x6013584")]
	[Address(RVA = "0x1052C00", Offset = "0x1052C00", VA = "0x1052C00")]
	public void ClearDescData()
	{
	}
}
