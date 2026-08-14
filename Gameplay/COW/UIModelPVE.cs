using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031E5")]
public class UIModelPVE : UIBaseModel
{
	[Token(Token = "0x20031E6")]
	private sealed class _003CChoosePVEPrimaryWeapon_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013004")]
		[FieldOffset(Offset = "0x8")]
		internal bool showTips;

		[Token(Token = "0x4013005")]
		[FieldOffset(Offset = "0xC")]
		internal uint weapon;

		[Token(Token = "0x4013006")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelPVE _0024this;

		[Token(Token = "0x60150DB")]
		[Address(RVA = "0x31ACA34", Offset = "0x31ACA34", VA = "0x31ACA34")]
		public _003CChoosePVEPrimaryWeapon_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60150DC")]
		[Address(RVA = "0x31ACA3C", Offset = "0x31ACA3C", VA = "0x31ACA3C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031E7")]
	private sealed class _003CAllOpeningPVEMap_003Ec__AnonStorey1
	{
		[Token(Token = "0x4013007")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelMapOpeningInfo modelMapOpenInfo;

		[Token(Token = "0x60150DD")]
		[Address(RVA = "0x31AC9B4", Offset = "0x31AC9B4", VA = "0x31AC9B4")]
		public _003CAllOpeningPVEMap_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60150DE")]
		[Address(RVA = "0x31AC9BC", Offset = "0x31AC9BC", VA = "0x31AC9BC")]
		internal bool _003C_003Em__0(MapOpeningInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4013001")]
	[FieldOffset(Offset = "0xC")]
	private uint m_PVEPrimaryWeaponSkin;

	[Token(Token = "0x4013002")]
	[FieldOffset(Offset = "0x10")]
	private uint m_SyncExpiredWeapon;

	[Token(Token = "0x4013003")]
	public const uint PropID_PrimaryWeapon_Updated = 2u;

	[Token(Token = "0x60150C9")]
	[Address(RVA = "0x2B2E050", Offset = "0x2B2E050", VA = "0x2B2E050")]
	public UIModelPVE()
	{
	}

	[Token(Token = "0x60150CA")]
	[Address(RVA = "0x2B2E0D4", Offset = "0x2B2E0D4", VA = "0x2B2E0D4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60150CB")]
	[Address(RVA = "0x2B2E12C", Offset = "0x2B2E12C", VA = "0x2B2E12C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60150CC")]
	[Address(RVA = "0x2B2E19C", Offset = "0x2B2E19C", VA = "0x2B2E19C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60150CD")]
	[Address(RVA = "0x2B2E2CC", Offset = "0x2B2E2CC", VA = "0x2B2E2CC")]
	public uint PrimaryWeapon()
	{
		return default(uint);
	}

	[Token(Token = "0x60150CE")]
	[Address(RVA = "0x2B2E7C4", Offset = "0x2B2E7C4", VA = "0x2B2E7C4")]
	public uint AvatarDefaultWeapon(uint avatarId)
	{
		return default(uint);
	}

	[Token(Token = "0x60150CF")]
	[Address(RVA = "0x2B2E99C", Offset = "0x2B2E99C", VA = "0x2B2E99C")]
	public uint CurrentAvatarDefaultWeapon()
	{
		return default(uint);
	}

	[Token(Token = "0x60150D0")]
	[Address(RVA = "0x2B2E4D0", Offset = "0x2B2E4D0", VA = "0x2B2E4D0")]
	public void ChoosePVEPrimaryWeapon(uint weapon, ulong groupid = 0uL, bool showTips = true, uint httpOption = 0u)
	{
	}

	[Token(Token = "0x60150D1")]
	[Address(RVA = "0x2B2EAC8", Offset = "0x2B2EAC8", VA = "0x2B2EAC8")]
	public uint[] AllPVEWeapons()
	{
		return null;
	}

	[Token(Token = "0x60150D2")]
	[Address(RVA = "0x2B2EBBC", Offset = "0x2B2EBBC", VA = "0x2B2EBBC")]
	public void UpdateWeapon(uint weaponID)
	{
	}

	[Token(Token = "0x60150D3")]
	[Address(RVA = "0x2B2EF58", Offset = "0x2B2EF58", VA = "0x2B2EF58")]
	public bool WeaponIsUnlock(uint weaponID)
	{
		return default(bool);
	}

	[Token(Token = "0x60150D4")]
	[Address(RVA = "0x2B2F10C", Offset = "0x2B2F10C", VA = "0x2B2F10C")]
	public CSSharedAvatarData AvatarAssociatedWithDefaultWeapon(uint weaponID)
	{
		return null;
	}

	[Token(Token = "0x60150D5")]
	[Address(RVA = "0x2B2F20C", Offset = "0x2B2F20C", VA = "0x2B2F20C")]
	public List<MapOpeningInfo> AllOpeningPVEMap()
	{
		return null;
	}

	[Token(Token = "0x60150D6")]
	[Address(RVA = "0x2B2F3F0", Offset = "0x2B2F3F0", VA = "0x2B2F3F0")]
	public static bool IsPVEMode(uint gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x60150D7")]
	[Address(RVA = "0x2B2F458", Offset = "0x2B2F458", VA = "0x2B2F458")]
	public bool HasPVEGameOpening()
	{
		return default(bool);
	}

	[Token(Token = "0x60150D8")]
	[Address(RVA = "0x2B2F530", Offset = "0x2B2F530", VA = "0x2B2F530")]
	private void _003CUpdateWeapon_003Em__0()
	{
	}

	[Token(Token = "0x60150D9")]
	[Address(RVA = "0x2B2F698", Offset = "0x2B2F698", VA = "0x2B2F698")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60150DA")]
	[Address(RVA = "0x2B2F6A0", Offset = "0x2B2F6A0", VA = "0x2B2F6A0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
