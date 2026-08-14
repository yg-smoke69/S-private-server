using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20032BD")]
public class UIModelWeaponRack : UIBaseModel
{
	[Token(Token = "0x4013517")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> EquipedWeapponIds;

	[Token(Token = "0x4013518")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> LastEquipedWeaponIds;

	[Token(Token = "0x4013519")]
	public const uint PropID_Add_Success = 2u;

	[Token(Token = "0x401351A")]
	public const uint PropID_Del_Success = 4u;

	[Token(Token = "0x401351B")]
	public const int SLOTCOUNT = 3;

	[Token(Token = "0x401351C")]
	public const string HDWEAPONRACKGUIDE = "HDWEAPONRACKGUIDE_";

	[Token(Token = "0x401351D")]
	[FieldOffset(Offset = "0x14")]
	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	[Token(Token = "0x170016B3")]
	public bool GetDataAfterLogin
	{
		[Token(Token = "0x6015689")]
		[Address(RVA = "0x1942F04", Offset = "0x1942F04", VA = "0x1942F04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601568A")]
		[Address(RVA = "0x1942F0C", Offset = "0x1942F0C", VA = "0x1942F0C")]
		private set
		{
		}
	}

	[Token(Token = "0x6015688")]
	[Address(RVA = "0x1942E34", Offset = "0x1942E34", VA = "0x1942E34")]
	public UIModelWeaponRack()
	{
	}

	[Token(Token = "0x601568B")]
	[Address(RVA = "0x1942F14", Offset = "0x1942F14", VA = "0x1942F14", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601568C")]
	[Address(RVA = "0x1942F6C", Offset = "0x1942F6C", VA = "0x1942F6C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601568D")]
	[Address(RVA = "0x1943078", Offset = "0x1943078", VA = "0x1943078")]
	public void AddWeapon(uint slot, uint weapon_id)
	{
	}

	[Token(Token = "0x601568E")]
	[Address(RVA = "0x1943780", Offset = "0x1943780", VA = "0x1943780")]
	public void DelWeapon(uint slot, uint weapon_id)
	{
	}

	[Token(Token = "0x601568F")]
	[Address(RVA = "0x194389C", Offset = "0x194389C", VA = "0x194389C")]
	public void ProcessDesc(WeaponRackRes res)
	{
	}

	[Token(Token = "0x6015690")]
	[Address(RVA = "0x1943AB4", Offset = "0x1943AB4", VA = "0x1943AB4")]
	public void RequestUpdateWeaponList()
	{
	}

	[Token(Token = "0x6015691")]
	[Address(RVA = "0x1943E30", Offset = "0x1943E30", VA = "0x1943E30")]
	public bool HasWeaponEquipped()
	{
		return default(bool);
	}

	[Token(Token = "0x6015692")]
	[Address(RVA = "0x1943FD4", Offset = "0x1943FD4", VA = "0x1943FD4")]
	public void RefreshDataAfterUpdateWeaponSkin(uint lastID, uint currentID)
	{
	}

	[Token(Token = "0x6015693")]
	[Address(RVA = "0x19441D8", Offset = "0x19441D8", VA = "0x19441D8")]
	private void _003CRequestUpdateWeaponList_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015694")]
	[Address(RVA = "0x19442A8", Offset = "0x19442A8", VA = "0x19442A8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
