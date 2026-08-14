using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200272B")]
public class UIHudDetectorController : UIBaseController
{
	[Token(Token = "0x400F1B6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDetectorView m_View;

	[Token(Token = "0x400F1B7")]
	private const float BIG_MAP_X = -150f;

	[Token(Token = "0x400F1B8")]
	[FieldOffset(Offset = "0x2C")]
	private float m_InitialX;

	[Token(Token = "0x600EE60")]
	[Address(RVA = "0x1CD28B4", Offset = "0x1CD28B4", VA = "0x1CD28B4")]
	public UIHudDetectorController()
	{
	}

	[Token(Token = "0x600EE61")]
	[Address(RVA = "0x1CD2938", Offset = "0x1CD2938", VA = "0x1CD2938")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EE62")]
	[Address(RVA = "0x1CD29E0", Offset = "0x1CD29E0", VA = "0x1CD29E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EE63")]
	[Address(RVA = "0x1CD2CD0", Offset = "0x1CD2CD0", VA = "0x1CD2CD0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EE64")]
	[Address(RVA = "0x1CD2FA4", Offset = "0x1CD2FA4", VA = "0x1CD2FA4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EE65")]
	[Address(RVA = "0x1CD3698", Offset = "0x1CD3698", VA = "0x1CD3698")]
	private void OnEnableBigMap(object[] param)
	{
	}

	[Token(Token = "0x600EE66")]
	[Address(RVA = "0x1CD37E8", Offset = "0x1CD37E8", VA = "0x1CD37E8")]
	private void OnDisableBigMap(object[] param)
	{
	}

	[Token(Token = "0x600EE67")]
	[Address(RVA = "0x1CD3708", Offset = "0x1CD3708", VA = "0x1CD3708")]
	private void SetX(float x)
	{
	}

	[Token(Token = "0x600EE68")]
	[Address(RVA = "0x1CD30C4", Offset = "0x1CD30C4", VA = "0x1CD30C4")]
	private void UpdateCount(object[] param)
	{
	}

	[Token(Token = "0x600EE69")]
	[Address(RVA = "0x1CD3580", Offset = "0x1CD3580", VA = "0x1CD3580")]
	private void CheckPlayerStatus(object[] param)
	{
	}

	[Token(Token = "0x600EE6A")]
	[Address(RVA = "0x1CD3854", Offset = "0x1CD3854", VA = "0x1CD3854")]
	private static Player GetLocalPlayer()
	{
		return null;
	}

	[Token(Token = "0x600EE6B")]
	[Address(RVA = "0x1CD39A8", Offset = "0x1CD39A8", VA = "0x1CD39A8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EE6C")]
	[Address(RVA = "0x1CD39B0", Offset = "0x1CD39B0", VA = "0x1CD39B0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EE6D")]
	[Address(RVA = "0x1CD39B8", Offset = "0x1CD39B8", VA = "0x1CD39B8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
