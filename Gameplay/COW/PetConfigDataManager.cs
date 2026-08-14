using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E0C")]
public class PetConfigDataManager : SingletonModule<PetConfigDataManager>
{
	[Token(Token = "0x4011A37")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, List<PetSkillInfoData>> m_skillInfo_list;

	[Token(Token = "0x4011A38")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, PetSkillInfoData> m_skillMap;

	[Token(Token = "0x4011A39")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<PetSkinData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601348D")]
	[Address(RVA = "0x1BF9928", Offset = "0x1BF9928", VA = "0x1BF9928")]
	public PetConfigDataManager()
	{
	}

	[Token(Token = "0x601348E")]
	[Address(RVA = "0x1BF9A20", Offset = "0x1BF9A20", VA = "0x1BF9A20", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601348F")]
	[Address(RVA = "0x1BF9B0C", Offset = "0x1BF9B0C", VA = "0x1BF9B0C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013490")]
	[Address(RVA = "0x1BF9BD4", Offset = "0x1BF9BD4", VA = "0x1BF9BD4")]
	public List<PetSkillInfoData> GetPetSkillDataByPetID(uint pet_id)
	{
		return null;
	}

	[Token(Token = "0x6013491")]
	[Address(RVA = "0x1BFA048", Offset = "0x1BFA048", VA = "0x1BFA048")]
	public PetOpenTimeData GetOpenTimeData(uint petID, string region)
	{
		return null;
	}

	[Token(Token = "0x6013492")]
	[Address(RVA = "0x1BFA284", Offset = "0x1BFA284", VA = "0x1BFA284")]
	public List<PetSkillInfoData> GetSkillInfoDataList(uint pet_id)
	{
		return null;
	}

	[Token(Token = "0x6013493")]
	[Address(RVA = "0x1BFA2F0", Offset = "0x1BFA2F0", VA = "0x1BFA2F0")]
	public PetSkillInfoData GetSkillInfoData(uint skillID)
	{
		return null;
	}

	[Token(Token = "0x6013494")]
	[Address(RVA = "0x1BFA3D4", Offset = "0x1BFA3D4", VA = "0x1BFA3D4")]
	public PetSkillLevelData GetCurrentSkillLevelData(uint skillID, uint level)
	{
		return null;
	}

	[Token(Token = "0x6013495")]
	[Address(RVA = "0x1BFA648", Offset = "0x1BFA648", VA = "0x1BFA648")]
	public List<PetSkillLevelData> GetSkillLevelDataListBySkillID(uint skill_id)
	{
		return null;
	}

	[Token(Token = "0x6013496")]
	[Address(RVA = "0x1BFAA90", Offset = "0x1BFAA90", VA = "0x1BFAA90")]
	public int GetMinLevelOfSkill(uint skillID)
	{
		return default(int);
	}

	[Token(Token = "0x6013497")]
	[Address(RVA = "0x1BFAC90", Offset = "0x1BFAC90", VA = "0x1BFAC90")]
	public int GetMaxLevelOfSkill(uint skillID)
	{
		return default(int);
	}

	[Token(Token = "0x6013498")]
	[Address(RVA = "0x1BFAE90", Offset = "0x1BFAE90", VA = "0x1BFAE90")]
	public List<PetSkillLevelData> GetAllSkillLevelDataListByPetID(uint pet_id)
	{
		return null;
	}

	[Token(Token = "0x6013499")]
	[Address(RVA = "0x1BFB3AC", Offset = "0x1BFB3AC", VA = "0x1BFB3AC")]
	public PetSkillLevelData GetSkillLevelData(uint skillID, uint skillLevel)
	{
		return null;
	}

	[Token(Token = "0x601349A")]
	[Address(RVA = "0x1BFB698", Offset = "0x1BFB698", VA = "0x1BFB698")]
	public List<PetActionData> GetPetActionDataByPetID(uint pet_id)
	{
		return null;
	}

	[Token(Token = "0x601349B")]
	[Address(RVA = "0x1BFB9BC", Offset = "0x1BFB9BC", VA = "0x1BFB9BC")]
	public List<PetSkinData> GetPetSkinDataByPetID(uint pet_id)
	{
		return null;
	}

	[Token(Token = "0x601349C")]
	[Address(RVA = "0x1BFBCE0", Offset = "0x1BFBCE0", VA = "0x1BFBCE0")]
	public List<PetActionData> GetNewUnlockPetActionDataByLvUp(uint pet_id, uint level_old, uint level_new)
	{
		return null;
	}

	[Token(Token = "0x601349D")]
	[Address(RVA = "0x1BFBF30", Offset = "0x1BFBF30", VA = "0x1BFBF30")]
	public List<PetSkinData> GetNewUnlockPetSkinDataByLvUp(uint pet_id, uint level_old, uint level_new)
	{
		return null;
	}

	[Token(Token = "0x601349E")]
	[Address(RVA = "0x1BFC180", Offset = "0x1BFC180", VA = "0x1BFC180")]
	public List<PetSkillInfoData> GetNewUnlockPetSkillDataByLvUp(uint pet_id, uint level_old, uint level_new)
	{
		return null;
	}

	[Token(Token = "0x601349F")]
	[Address(RVA = "0x1BFC494", Offset = "0x1BFC494", VA = "0x1BFC494")]
	public uint GetPetDefaultSkinID(uint pet_id)
	{
		return default(uint);
	}

	[Token(Token = "0x60134A0")]
	[Address(RVA = "0x1BFC600", Offset = "0x1BFC600", VA = "0x1BFC600")]
	public ResourceID GetPetLobbyBasicActionResByID(uint pet_id)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60134A1")]
	[Address(RVA = "0x1BFC780", Offset = "0x1BFC780", VA = "0x1BFC780")]
	private static bool _003CGetPetDefaultSkinID_003Em__0(PetSkinData temp)
	{
		return default(bool);
	}
}
