using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA9")]
internal class AvatarSkillDataManager : SingletonModule<AvatarSkillDataManager>
{
	[Token(Token = "0x401187A")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, AvatarSkillData> m_SkillDict;

	[Token(Token = "0x401187B")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, List<AvatarSkillData>> m_AvatarSkillDict;

	[Token(Token = "0x60131DB")]
	[Address(RVA = "0x235DE20", Offset = "0x235DE20", VA = "0x235DE20")]
	public AvatarSkillDataManager()
	{
	}

	[Token(Token = "0x60131DC")]
	[Address(RVA = "0x235DF18", Offset = "0x235DF18", VA = "0x235DF18", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60131DD")]
	[Address(RVA = "0x235E3D0", Offset = "0x235E3D0", VA = "0x235E3D0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60131DE")]
	[Address(RVA = "0x235E4BC", Offset = "0x235E4BC", VA = "0x235E4BC")]
	public List<AvatarSkillData> GetAvatarSkillList(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x60131DF")]
	[Address(RVA = "0x235E5D4", Offset = "0x235E5D4", VA = "0x235E5D4")]
	public List<AvatarSkillData> GetAvatarSkillListBySkillId(uint skillid)
	{
		return null;
	}

	[Token(Token = "0x60131E0")]
	[Address(RVA = "0x235BB30", Offset = "0x235BB30", VA = "0x235BB30")]
	public AvatarSkillData GetAvatarSkillDataByLevel(uint avatarID, uint level = 1u)
	{
		return null;
	}

	[Token(Token = "0x60131E1")]
	[Address(RVA = "0x235E6C8", Offset = "0x235E6C8", VA = "0x235E6C8")]
	public AvatarSkillData GetMaxLevelSkillDataByAvatarID(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x60131E2")]
	[Address(RVA = "0x234E5E8", Offset = "0x234E5E8", VA = "0x234E5E8")]
	public AvatarSkillData GetAvatarSkillDataBySkillID(uint skillID)
	{
		return null;
	}
}
