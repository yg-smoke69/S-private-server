using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022A2")]
public class PhotographModeController : UIBaseController
{
	[Token(Token = "0x20022A3")]
	private enum PhotoHideMode
	{
		[Token(Token = "0x400D8CE")]
		PhotoHideMode_ShowAll,
		[Token(Token = "0x400D8CF")]
		PhotoHideMode_TeammateOnly,
		[Token(Token = "0x400D8D0")]
		PhotoHideMode_HideAll
	}

	[Token(Token = "0x400D8C5")]
	[FieldOffset(Offset = "0x28")]
	private PhotographModeView m_View;

	[Token(Token = "0x400D8C6")]
	[FieldOffset(Offset = "0x2C")]
	private Action m_TakePhotoCallBack;

	[Token(Token = "0x400D8C7")]
	[FieldOffset(Offset = "0x30")]
	private ResourceID m_SoundId;

	[Token(Token = "0x400D8C8")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsCoverDefaultSound;

	[Token(Token = "0x400D8C9")]
	[FieldOffset(Offset = "0x38")]
	private PhotoHideMode m_CurHideMode;

	[Token(Token = "0x400D8CA")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PARTY_PHOTOGRAPH_HIDEMODE_SHOW_ALL;

	[Token(Token = "0x400D8CB")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string PARTY_PHOTOGRAPH_HIDEMODE_TEAMMATE_ONLY;

	[Token(Token = "0x400D8CC")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string PARTY_PHOTOGRAPH_HIDEMODE_HIDE_ALL;

	[Token(Token = "0x600BE5F")]
	[Address(RVA = "0x1C022FC", Offset = "0x1C022FC", VA = "0x1C022FC")]
	public PhotographModeController()
	{
	}

	[Token(Token = "0x600BE60")]
	[Address(RVA = "0x1C02380", Offset = "0x1C02380", VA = "0x1C02380")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE61")]
	[Address(RVA = "0x1C02428", Offset = "0x1C02428", VA = "0x1C02428", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BE62")]
	[Address(RVA = "0x1C0284C", Offset = "0x1C0284C", VA = "0x1C0284C", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600BE63")]
	[Address(RVA = "0x1C02980", Offset = "0x1C02980", VA = "0x1C02980", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600BE64")]
	[Address(RVA = "0x1C02F3C", Offset = "0x1C02F3C", VA = "0x1C02F3C")]
	private void OnPlayerStateChange(object[] data)
	{
	}

	[Token(Token = "0x600BE65")]
	[Address(RVA = "0x1C03110", Offset = "0x1C03110", VA = "0x1C03110")]
	public void SetTakePhotoParam(Action takePhotoCallBack, ResourceID soundId, bool isCoverDefaultSound)
	{
	}

	[Token(Token = "0x600BE66")]
	[Address(RVA = "0x1C0324C", Offset = "0x1C0324C", VA = "0x1C0324C")]
	private void TakePhoto()
	{
	}

	[Token(Token = "0x600BE67")]
	[Address(RVA = "0x1C03B98", Offset = "0x1C03B98", VA = "0x1C03B98")]
	private void FromSharePage()
	{
	}

	[Token(Token = "0x600BE68")]
	[Address(RVA = "0x1C03C60", Offset = "0x1C03C60", VA = "0x1C03C60")]
	private void OnHideOthersClick()
	{
	}

	[Token(Token = "0x600BE69")]
	[Address(RVA = "0x1C02B80", Offset = "0x1C02B80", VA = "0x1C02B80")]
	private void UpdateHideOthersBtnIcon()
	{
	}

	[Token(Token = "0x600BE6A")]
	[Address(RVA = "0x1C04850", Offset = "0x1C04850", VA = "0x1C04850", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600BE6B")]
	[Address(RVA = "0x1C04A5C", Offset = "0x1C04A5C", VA = "0x1C04A5C", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600BE6C")]
	[Address(RVA = "0x1C02D6C", Offset = "0x1C02D6C", VA = "0x1C02D6C")]
	private void ScaleCamera()
	{
	}

	[Token(Token = "0x600BE6D")]
	[Address(RVA = "0x1C04C30", Offset = "0x1C04C30", VA = "0x1C04C30")]
	private void ExitPhotographMode()
	{
	}

	[Token(Token = "0x600BE6E")]
	[Address(RVA = "0x1C04D68", Offset = "0x1C04D68", VA = "0x1C04D68")]
	private void OpenEmotePanel()
	{
	}

	[Token(Token = "0x600BE70")]
	[Address(RVA = "0x1C04EFC", Offset = "0x1C04EFC", VA = "0x1C04EFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BE71")]
	[Address(RVA = "0x1C04F04", Offset = "0x1C04F04", VA = "0x1C04F04")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600BE72")]
	[Address(RVA = "0x1C04F0C", Offset = "0x1C04F0C", VA = "0x1C04F0C")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x600BE73")]
	[Address(RVA = "0x1C04F14", Offset = "0x1C04F14", VA = "0x1C04F14")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600BE74")]
	[Address(RVA = "0x1C04F1C", Offset = "0x1C04F1C", VA = "0x1C04F1C")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
