using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D45")]
public class TipsManager : SingletonModule<TipsManager>
{
	[Token(Token = "0x4011525")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, int> m_TipsDataStore;

	[Token(Token = "0x4011526")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, List<ITipsDelegate>> m_TipsDelegates;

	[Token(Token = "0x4011527")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, CSVBaseData> m_ShowRuleDict;

	[Token(Token = "0x4011528")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, CSVBaseData> m_SpShowRuleDict;

	[Token(Token = "0x6012F2E")]
	[Address(RVA = "0x28A9AE4", Offset = "0x28A9AE4", VA = "0x28A9AE4")]
	public TipsManager()
	{
	}

	[Token(Token = "0x6012F2F")]
	[Address(RVA = "0x28A9BDC", Offset = "0x28A9BDC", VA = "0x28A9BDC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6012F30")]
	[Address(RVA = "0x28A9D24", Offset = "0x28A9D24", VA = "0x28A9D24", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6012F31")]
	[Address(RVA = "0x28A9E20", Offset = "0x28A9E20", VA = "0x28A9E20")]
	public void SetTipsNum(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6012F32")]
	[Address(RVA = "0x28AA1B8", Offset = "0x28AA1B8", VA = "0x28AA1B8")]
	public TipsGoShowRuleData GetSettingDataByType(ETipsType tipsType)
	{
		return null;
	}

	[Token(Token = "0x6012F33")]
	[Address(RVA = "0x28AA35C", Offset = "0x28AA35C", VA = "0x28AA35C")]
	public bool CheckCanShowSPTip(ESpTipsType spTipType)
	{
		return default(bool);
	}

	[Token(Token = "0x6012F34")]
	[Address(RVA = "0x28AA4A4", Offset = "0x28AA4A4", VA = "0x28AA4A4")]
	private uint GetSpTipLevelLimit(ESpTipsType spTipType)
	{
		return default(uint);
	}

	[Token(Token = "0x6012F35")]
	[Address(RVA = "0x28AA528", Offset = "0x28AA528", VA = "0x28AA528")]
	private SpTipsGoShowRuleData GetSpTipShowRuleData(ESpTipsType spTipType)
	{
		return null;
	}

	[Token(Token = "0x6012F36")]
	[Address(RVA = "0x28AA6CC", Offset = "0x28AA6CC", VA = "0x28AA6CC")]
	public int GetTipsNum(ETipsType type)
	{
		return default(int);
	}

	[Token(Token = "0x6012F37")]
	[Address(RVA = "0x28AAB5C", Offset = "0x28AAB5C", VA = "0x28AAB5C")]
	public void AddTipsNum(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6012F38")]
	[Address(RVA = "0x28AABF0", Offset = "0x28AABF0", VA = "0x28AABF0")]
	public void ClearTipsNum(ETipsType type)
	{
	}

	[Token(Token = "0x6012F39")]
	[Address(RVA = "0x28AAD94", Offset = "0x28AAD94", VA = "0x28AAD94")]
	public void ClearTipsNumIncludeChild(ETipsType type)
	{
	}

	[Token(Token = "0x6012F3A")]
	[Address(RVA = "0x28AAF00", Offset = "0x28AAF00", VA = "0x28AAF00")]
	public void ClearParentTipsWithoutChild(ETipsType type)
	{
	}

	[Token(Token = "0x6012F3B")]
	[Address(RVA = "0x28AB2F4", Offset = "0x28AB2F4", VA = "0x28AB2F4")]
	public void RegisterTipsDelegate(ETipsType type, ITipsDelegate del)
	{
	}

	[Token(Token = "0x6012F3C")]
	[Address(RVA = "0x28AB3E4", Offset = "0x28AB3E4", VA = "0x28AB3E4")]
	public void UnRegisterTipsDelegate(ETipsType type, ITipsDelegate del)
	{
	}

	[Token(Token = "0x6012F3D")]
	[Address(RVA = "0x28A9F74", Offset = "0x28A9F74", VA = "0x28A9F74")]
	public void NotifyTipsChange(ETipsType type)
	{
	}

	[Token(Token = "0x6012F3E")]
	[Address(RVA = "0x28AB164", Offset = "0x28AB164", VA = "0x28AB164")]
	private List<ITipsDelegate> GetDelegateList(ETipsType type)
	{
		return null;
	}

	[Token(Token = "0x6012F3F")]
	[Address(RVA = "0x28AB5F4", Offset = "0x28AB5F4", VA = "0x28AB5F4")]
	public void PrintDelegates()
	{
	}
}
