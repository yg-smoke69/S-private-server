using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20000B1")]
public class AvatarSkillSlotDataManager : SingletonModule<AvatarSkillSlotDataManager>
{
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, AvatarSkillSlotData> m_AvailableAvatarSkillSlotData;

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x236015C", Offset = "0x236015C", VA = "0x236015C")]
	public AvatarSkillSlotDataManager()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x2360220", Offset = "0x2360220", VA = "0x2360220", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x236075C", Offset = "0x236075C", VA = "0x236075C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x2360824", Offset = "0x2360824", VA = "0x2360824")]
	public Dictionary<uint, AvatarSkillSlotData> GetAllSkillSlotData()
	{
		return null;
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x236087C", Offset = "0x236087C", VA = "0x236087C")]
	public AvatarSkillSlotData FindAvatarSkillSlotDataById(uint avatarId)
	{
		return null;
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x236096C", Offset = "0x236096C", VA = "0x236096C")]
	public int GetUnLockSkillCost(uint avatarID, int slotIndex, EInventory.CurrencyType currencyType)
	{
		return default(int);
	}
}
