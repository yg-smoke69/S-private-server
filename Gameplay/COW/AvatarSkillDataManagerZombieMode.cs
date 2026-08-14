using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002DAA")]
internal class AvatarSkillDataManagerZombieMode : SingletonModule<AvatarSkillDataManagerZombieMode>
{
	[Token(Token = "0x401187C")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, AvatarSkillData> m_SkillDict;

	[Token(Token = "0x401187D")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, List<AvatarSkillData>> m_AvatarSkillDict;

	[Token(Token = "0x401187E")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<int, string> m_Level2SkillBgName;

	[Token(Token = "0x401187F")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, uint> m_Level2SkillLabelColor;

	[Token(Token = "0x4011880")]
	public const uint DynamicOrEnhancedSkillInitialLevel = 7u;

	[Token(Token = "0x60131E3")]
	[Address(RVA = "0x235E878", Offset = "0x235E878", VA = "0x235E878")]
	public AvatarSkillDataManagerZombieMode()
	{
	}

	[Token(Token = "0x60131E4")]
	[Address(RVA = "0x235EC08", Offset = "0x235EC08", VA = "0x235EC08")]
	public string GetSkillBgName(int level)
	{
		return null;
	}

	[Token(Token = "0x60131E5")]
	[Address(RVA = "0x235ED54", Offset = "0x235ED54", VA = "0x235ED54")]
	public Color GetSkillLabelColor(int level)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x60131E6")]
	[Address(RVA = "0x235EE84", Offset = "0x235EE84", VA = "0x235EE84", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60131E7")]
	[Address(RVA = "0x235F37C", Offset = "0x235F37C", VA = "0x235F37C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60131E8")]
	[Address(RVA = "0x235F468", Offset = "0x235F468", VA = "0x235F468")]
	public List<AvatarSkillData> GetAvatarSkillList(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x60131E9")]
	[Address(RVA = "0x235F580", Offset = "0x235F580", VA = "0x235F580")]
	public List<AvatarSkillData> GetAvatarSkillListBySkillId(uint skillid)
	{
		return null;
	}

	[Token(Token = "0x60131EA")]
	[Address(RVA = "0x235B934", Offset = "0x235B934", VA = "0x235B934")]
	public AvatarSkillData GetAvatarSkillDataByLevel(uint avatarID, uint level = 1u)
	{
		return null;
	}

	[Token(Token = "0x60131EB")]
	[Address(RVA = "0x235BD2C", Offset = "0x235BD2C", VA = "0x235BD2C")]
	public AvatarSkillData GetAvatarSkillDataBySkillID(uint skillID)
	{
		return null;
	}
}
