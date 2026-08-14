using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200334A")]
internal class UIHudBombCountDownTimeController : UIBaseController
{
	[Token(Token = "0x40138A5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBombCountDownTimeView m_View;

	[Token(Token = "0x40138A6")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_BombExplodeTime;

	[Token(Token = "0x40138A7")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x40138A8")]
	[FieldOffset(Offset = "0x34")]
	private uint min;

	[Token(Token = "0x40138A9")]
	[FieldOffset(Offset = "0x38")]
	private uint sec;

	[Token(Token = "0x40138AA")]
	[FieldOffset(Offset = "0x3C")]
	private PJIBHMGGMEL bombGame;

	[Token(Token = "0x40138AB")]
	[FieldOffset(Offset = "0x0")]
	private static string ZoneAStr;

	[Token(Token = "0x40138AC")]
	[FieldOffset(Offset = "0x4")]
	private static string ZoneBStr;

	[Token(Token = "0x6015CB7")]
	[Address(RVA = "0x1E07EF8", Offset = "0x1E07EF8", VA = "0x1E07EF8")]
	public UIHudBombCountDownTimeController()
	{
	}

	[Token(Token = "0x6015CB8")]
	[Address(RVA = "0x1E07F7C", Offset = "0x1E07F7C", VA = "0x1E07F7C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015CB9")]
	[Address(RVA = "0x1E08020", Offset = "0x1E08020", VA = "0x1E08020", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015CBA")]
	[Address(RVA = "0x1E082CC", Offset = "0x1E082CC", VA = "0x1E082CC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015CBB")]
	[Address(RVA = "0x1E08468", Offset = "0x1E08468", VA = "0x1E08468")]
	private void OnBombSettingPhaseSync(object[] data)
	{
	}

	[Token(Token = "0x6015CBC")]
	[Address(RVA = "0x1E08530", Offset = "0x1E08530", VA = "0x1E08530")]
	private void OnBombPlantTimeSync(object[] data)
	{
	}

	[Token(Token = "0x6015CBD")]
	[Address(RVA = "0x1E0861C", Offset = "0x1E0861C", VA = "0x1E0861C")]
	private void Update()
	{
	}

	[Token(Token = "0x6015CBF")]
	[Address(RVA = "0x1E09700", Offset = "0x1E09700", VA = "0x1E09700")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015CC0")]
	[Address(RVA = "0x1E09708", Offset = "0x1E09708", VA = "0x1E09708")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
