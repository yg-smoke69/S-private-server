using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A0F")]
internal class UIOBPlayerNamePlateController : UIBaseController
{
	[Token(Token = "0x40102B5")]
	[FieldOffset(Offset = "0x28")]
	private UIOBPlayerNamePlateView m_View;

	[Token(Token = "0x40102B6")]
	[FieldOffset(Offset = "0x2C")]
	private OBPlayerState_Base m_CurState;

	[Token(Token = "0x40102B7")]
	[FieldOffset(Offset = "0x30")]
	private PlayerData m_PlayerData;

	[Token(Token = "0x40102B8")]
	[FieldOffset(Offset = "0x34")]
	private bool m_EnableGoto;

	[Token(Token = "0x40102B9")]
	[FieldOffset(Offset = "0x38")]
	private uint m_FiringRayDelayCall;

	[Token(Token = "0x40102BA")]
	private const int MAXDEPTH = 500;

	[Token(Token = "0x40102BB")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, OBPlayerState_Base> m_OBStateCache;

	[Token(Token = "0x40102BC")]
	[FieldOffset(Offset = "0x40")]
	private uint m_HurtDelayCallID;

	[Token(Token = "0x6010FFD")]
	[Address(RVA = "0x1599700", Offset = "0x1599700", VA = "0x1599700")]
	public UIOBPlayerNamePlateController()
	{
	}

	[Token(Token = "0x6010FFE")]
	[Address(RVA = "0x15997B8", Offset = "0x15997B8", VA = "0x15997B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010FFF")]
	[Address(RVA = "0x1599860", Offset = "0x1599860", VA = "0x1599860")]
	public EOBPlayerStateType CurrentStateType()
	{
		return default(EOBPlayerStateType);
	}

	[Token(Token = "0x6011000")]
	[Address(RVA = "0x15998DC", Offset = "0x15998DC", VA = "0x15998DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011001")]
	[Address(RVA = "0x159A0BC", Offset = "0x159A0BC", VA = "0x159A0BC")]
	public void InitDepth(int name_plate_depth)
	{
	}

	[Token(Token = "0x6011002")]
	[Address(RVA = "0x159A128", Offset = "0x159A128", VA = "0x159A128")]
	private void SetDepth(int name_plate_depth)
	{
	}

	[Token(Token = "0x6011003")]
	[Address(RVA = "0x159A550", Offset = "0x159A550", VA = "0x159A550")]
	public void BindPlayerData(PlayerData data, bool EnableGoto)
	{
	}

	[Token(Token = "0x6011004")]
	[Address(RVA = "0x159AB8C", Offset = "0x159AB8C", VA = "0x159AB8C")]
	public void UpdatePlayerInfo(bool needName = true)
	{
	}

	[Token(Token = "0x6011005")]
	[Address(RVA = "0x159AF84", Offset = "0x159AF84", VA = "0x159AF84")]
	public void PlayHurtEffect()
	{
	}

	[Token(Token = "0x6011006")]
	[Address(RVA = "0x159B19C", Offset = "0x159B19C", VA = "0x159B19C")]
	public void FireEffectVisibleChange(bool isVisible)
	{
	}

	[Token(Token = "0x6011007")]
	[Address(RVA = "0x159B254", Offset = "0x159B254", VA = "0x159B254")]
	public void DrawFiringRay(float scale)
	{
	}

	[Token(Token = "0x6011008")]
	[Address(RVA = "0x159B678", Offset = "0x159B678", VA = "0x159B678")]
	public void SwithPlayerState(EOBPlayerStateType next_state_type)
	{
	}

	[Token(Token = "0x6011009")]
	[Address(RVA = "0x159B87C", Offset = "0x159B87C", VA = "0x159B87C")]
	public void UpdatePlayerRotation()
	{
	}

	[Token(Token = "0x601100A")]
	[Address(RVA = "0x159BABC", Offset = "0x159BABC", VA = "0x159BABC")]
	public void UpdateNamePlateRotaion(float angle)
	{
	}

	[Token(Token = "0x601100B")]
	[Address(RVA = "0x159BC8C", Offset = "0x159BC8C", VA = "0x159BC8C")]
	public void UpdatePlayerPosition()
	{
	}

	[Token(Token = "0x601100C")]
	[Address(RVA = "0x159BEDC", Offset = "0x159BEDC", VA = "0x159BEDC")]
	public void ToggleNameplateName(bool visible)
	{
	}

	[Token(Token = "0x601100D")]
	[Address(RVA = "0x159BF74", Offset = "0x159BF74", VA = "0x159BF74")]
	private void OnGotoBtnClcik()
	{
	}

	[Token(Token = "0x601100E")]
	[Address(RVA = "0x159C09C", Offset = "0x159C09C", VA = "0x159C09C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601100F")]
	[Address(RVA = "0x159C2AC", Offset = "0x159C2AC", VA = "0x159C2AC")]
	private void OnToggleShowTeamIcon(object[] data)
	{
	}

	[Token(Token = "0x6011010")]
	[Address(RVA = "0x159C388", Offset = "0x159C388", VA = "0x159C388")]
	private void OnShowKok(object[] data)
	{
	}

	[Token(Token = "0x6011011")]
	[Address(RVA = "0x159A8F0", Offset = "0x159A8F0", VA = "0x159A8F0")]
	private void ShowTeamIcon(bool show)
	{
	}

	[Token(Token = "0x6011012")]
	[Address(RVA = "0x159C4E4", Offset = "0x159C4E4", VA = "0x159C4E4")]
	private void _003CPlayHurtEffect_003Em__0()
	{
	}

	[Token(Token = "0x6011013")]
	[Address(RVA = "0x159C540", Offset = "0x159C540", VA = "0x159C540")]
	private void _003CDrawFiringRay_003Em__1()
	{
	}

	[Token(Token = "0x6011014")]
	[Address(RVA = "0x159C5B0", Offset = "0x159C5B0", VA = "0x159C5B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011015")]
	[Address(RVA = "0x159C5B8", Offset = "0x159C5B8", VA = "0x159C5B8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
