using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FEF")]
public class BountyRepairingRankController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C8CD")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDBountyRepairRankView m_View;

	[Token(Token = "0x400C8CE")]
	[FieldOffset(Offset = "0x2C")]
	private uint localPlayerPoint;

	[Token(Token = "0x400C8CF")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400C8D0")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsLockRepair;

	[Token(Token = "0x600A118")]
	[Address(RVA = "0x180EEB4", Offset = "0x180EEB4", VA = "0x180EEB4")]
	public BountyRepairingRankController()
	{
	}

	[Token(Token = "0x600A119")]
	[Address(RVA = "0x180EF38", Offset = "0x180EF38", VA = "0x180EF38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A11A")]
	[Address(RVA = "0x180EFE0", Offset = "0x180EFE0", VA = "0x180EFE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A11B")]
	[Address(RVA = "0x180F420", Offset = "0x180F420", VA = "0x180F420")]
	private void InitItemContent(BountyRepairingItem item)
	{
	}

	[Token(Token = "0x600A11C")]
	[Address(RVA = "0x180F5A4", Offset = "0x180F5A4", VA = "0x180F5A4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A11D")]
	[Address(RVA = "0x180F6FC", Offset = "0x180F6FC", VA = "0x180F6FC")]
	private void OnRepairRankChange(object[] param)
	{
	}

	[Token(Token = "0x600A11E")]
	[Address(RVA = "0x180FA90", Offset = "0x180FA90", VA = "0x180FA90", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A11F")]
	[Address(RVA = "0x180FB24", Offset = "0x180FB24", VA = "0x180FB24", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A120")]
	[Address(RVA = "0x180FC2C", Offset = "0x180FC2C", VA = "0x180FC2C")]
	public void LockTeleportMachine()
	{
	}

	[Token(Token = "0x600A121")]
	[Address(RVA = "0x180FD88", Offset = "0x180FD88", VA = "0x180FD88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A122")]
	[Address(RVA = "0x180FD90", Offset = "0x180FD90", VA = "0x180FD90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
