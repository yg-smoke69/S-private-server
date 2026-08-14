using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002683")]
public class UIGachaTurntableItemController : UIBaseController
{
	[Token(Token = "0x2002684")]
	public enum ViewStage
	{
		[Token(Token = "0x400EDBE")]
		NORMAL,
		[Token(Token = "0x400EDBF")]
		TRANSLUCENT,
		[Token(Token = "0x400EDC0")]
		HIGHLIGHT,
		[Token(Token = "0x400EDC1")]
		SELECTED,
		[Token(Token = "0x400EDC2")]
		GET_REWARD
	}

	[Token(Token = "0x400EDB9")]
	[FieldOffset(Offset = "0x28")]
	private uint m_GachaID;

	[Token(Token = "0x400EDBA")]
	[FieldOffset(Offset = "0x2C")]
	private UIGachaTurntableItemView m_View;

	[Token(Token = "0x400EDBB")]
	[FieldOffset(Offset = "0x30")]
	private int m_Idx;

	[Token(Token = "0x400EDBC")]
	[FieldOffset(Offset = "0x34")]
	private BaseItemInfo m_Info;

	[Token(Token = "0x1700118F")]
	public int Index
	{
		[Token(Token = "0x600E722")]
		[Address(RVA = "0x2E96D9C", Offset = "0x2E96D9C", VA = "0x2E96D9C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001190")]
	public BaseItemInfo Info
	{
		[Token(Token = "0x600E723")]
		[Address(RVA = "0x2E96DF4", Offset = "0x2E96DF4", VA = "0x2E96DF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600E721")]
	[Address(RVA = "0x2E99BE0", Offset = "0x2E99BE0", VA = "0x2E99BE0")]
	public UIGachaTurntableItemController()
	{
	}

	[Token(Token = "0x600E724")]
	[Address(RVA = "0x2E99C64", Offset = "0x2E99C64", VA = "0x2E99C64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E725")]
	[Address(RVA = "0x2E99D08", Offset = "0x2E99D08", VA = "0x2E99D08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E726")]
	[Address(RVA = "0x2E99EBC", Offset = "0x2E99EBC", VA = "0x2E99EBC")]
	private void OnBtnTipClick()
	{
	}

	[Token(Token = "0x600E727")]
	[Address(RVA = "0x2E93718", Offset = "0x2E93718", VA = "0x2E93718")]
	public void SetViewInfo(uint gachaID, int idx, BaseItemInfo info, bool isShowDropUp = false)
	{
	}

	[Token(Token = "0x600E728")]
	[Address(RVA = "0x2E93E44", Offset = "0x2E93E44", VA = "0x2E93E44")]
	public void ShowView(ViewStage stage, float alpha = 1f)
	{
	}

	[Token(Token = "0x600E729")]
	[Address(RVA = "0x2E9A02C", Offset = "0x2E9A02C", VA = "0x2E9A02C")]
	private void PlaySelectedAudio()
	{
	}

	[Token(Token = "0x600E72A")]
	[Address(RVA = "0x2E9A144", Offset = "0x2E9A144", VA = "0x2E9A144")]
	private void PlayGetRewardAudio()
	{
	}

	[Token(Token = "0x600E72B")]
	[Address(RVA = "0x2E9A25C", Offset = "0x2E9A25C", VA = "0x2E9A25C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E72C")]
	[Address(RVA = "0x2E9A2C0", Offset = "0x2E9A2C0", VA = "0x2E9A2C0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E72D")]
	[Address(RVA = "0x2E920FC", Offset = "0x2E920FC", VA = "0x2E920FC")]
	public void PlayAnim()
	{
	}

	[Token(Token = "0x600E72E")]
	[Address(RVA = "0x2E92448", Offset = "0x2E92448", VA = "0x2E92448")]
	public void ResetAnim()
	{
	}

	[Token(Token = "0x600E72F")]
	[Address(RVA = "0x2E9A324", Offset = "0x2E9A324", VA = "0x2E9A324")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E730")]
	[Address(RVA = "0x2E9A32C", Offset = "0x2E9A32C", VA = "0x2E9A32C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E731")]
	[Address(RVA = "0x2E9A334", Offset = "0x2E9A334", VA = "0x2E9A334")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
