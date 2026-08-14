using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002746")]
internal class UIHudEscortVehicleProgressController : UIBaseController
{
	[Token(Token = "0x2002747")]
	private struct MileStoneInfo
	{
		[Token(Token = "0x400F25D")]
		[FieldOffset(Offset = "0x0")]
		public UISprite ProgressBar;

		[Token(Token = "0x400F25E")]
		[FieldOffset(Offset = "0x4")]
		public UISprite FlagIcon;

		[Token(Token = "0x600EFA9")]
		[Address(RVA = "0x93C068", Offset = "0x93C068", VA = "0x93C068")]
		public MileStoneInfo(UISprite progressBar, UISprite flag)
		{
		}
	}

	[Token(Token = "0x400F255")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEscortVehicleProgressView m_View;

	[Token(Token = "0x400F256")]
	[FieldOffset(Offset = "0x2C")]
	private POECKIDCBKC mGame;

	[Token(Token = "0x400F257")]
	[FieldOffset(Offset = "0x30")]
	private MileStoneInfo[] m_MileStoneInfos;

	[Token(Token = "0x400F258")]
	private const int TOTAL_MILESTONE_COUNT = 4;

	[Token(Token = "0x400F259")]
	private const float TOTAL_PROGRESS_BAR_LENGHTH = 331.75f;

	[Token(Token = "0x400F25A")]
	[FieldOffset(Offset = "0x34")]
	private Color FLAG_FINISH_COLOR;

	[Token(Token = "0x400F25B")]
	[FieldOffset(Offset = "0x44")]
	private Color FLAG_UNFINISH_COLOR;

	[Token(Token = "0x400F25C")]
	[FieldOffset(Offset = "0x54")]
	private uint m_DelayCallID;

	[Token(Token = "0x600EF99")]
	[Address(RVA = "0x1B972C0", Offset = "0x1B972C0", VA = "0x1B972C0")]
	public UIHudEscortVehicleProgressController()
	{
	}

	[Token(Token = "0x600EF9A")]
	[Address(RVA = "0x1B97398", Offset = "0x1B97398", VA = "0x1B97398")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF9B")]
	[Address(RVA = "0x1B97440", Offset = "0x1B97440", VA = "0x1B97440", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF9C")]
	[Address(RVA = "0x1B97EE0", Offset = "0x1B97EE0", VA = "0x1B97EE0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EF9D")]
	[Address(RVA = "0x1B9821C", Offset = "0x1B9821C", VA = "0x1B9821C")]
	private void OnCurrentMileStoneChanged(object[] data)
	{
	}

	[Token(Token = "0x600EF9E")]
	[Address(RVA = "0x1B97A0C", Offset = "0x1B97A0C", VA = "0x1B97A0C")]
	private void UpdateMileStoneUI()
	{
	}

	[Token(Token = "0x600EF9F")]
	[Address(RVA = "0x1B98284", Offset = "0x1B98284", VA = "0x1B98284")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600EFA0")]
	[Address(RVA = "0x1B986CC", Offset = "0x1B986CC", VA = "0x1B986CC")]
	private void OnVehiclePositionChanged(object[] data)
	{
	}

	[Token(Token = "0x600EFA1")]
	[Address(RVA = "0x1B98A74", Offset = "0x1B98A74", VA = "0x1B98A74")]
	private void OnEffectiveAttackerChanged(object[] data)
	{
	}

	[Token(Token = "0x600EFA2")]
	[Address(RVA = "0x1B97DEC", Offset = "0x1B97DEC", VA = "0x1B97DEC")]
	private void RefreshEffectiveAttacker()
	{
	}

	[Token(Token = "0x600EFA3")]
	[Address(RVA = "0x1B98ADC", Offset = "0x1B98ADC", VA = "0x1B98ADC")]
	private void OnEffectiveDefenderChanged(object[] data)
	{
	}

	[Token(Token = "0x600EFA4")]
	[Address(RVA = "0x1B97CF8", Offset = "0x1B97CF8", VA = "0x1B97CF8")]
	private void RefreshEffectiveDefender()
	{
	}

	[Token(Token = "0x600EFA5")]
	[Address(RVA = "0x1B98B44", Offset = "0x1B98B44", VA = "0x1B98B44")]
	private void OnEquipmentConfirmed(object[] data)
	{
	}

	[Token(Token = "0x600EFA6")]
	[Address(RVA = "0x1B98F30", Offset = "0x1B98F30", VA = "0x1B98F30")]
	protected void WaitAndHide()
	{
	}

	[Token(Token = "0x600EFA7")]
	[Address(RVA = "0x1B98FC8", Offset = "0x1B98FC8", VA = "0x1B98FC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EFA8")]
	[Address(RVA = "0x1B98FD0", Offset = "0x1B98FD0", VA = "0x1B98FD0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
