using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FD1")]
public class UIAvatar : UIAvatarBase
{
	[Token(Token = "0x400C7A2")]
	[FieldOffset(Offset = "0x60")]
	protected uint m_AvatarID;

	[Token(Token = "0x400C7A3")]
	[FieldOffset(Offset = "0x64")]
	protected bool m_IsDirty;

	[Token(Token = "0x400C7A4")]
	[FieldOffset(Offset = "0x65")]
	protected bool m_IsCurrentModelFemale;

	[Token(Token = "0x400C7A5")]
	[FieldOffset(Offset = "0x66")]
	protected bool m_IsSettingAvatar;

	[Token(Token = "0x400C7A6")]
	[FieldOffset(Offset = "0x68")]
	protected CSSharedAvatarData m_SettingAvatarData;

	[Token(Token = "0x400C7A7")]
	[FieldOffset(Offset = "0x6C")]
	protected Coroutine m_PlayGunCoroutine;

	[Token(Token = "0x400C7A8")]
	[FieldOffset(Offset = "0x70")]
	protected Coroutine m_PlayGunAnimCoroutine;

	[Token(Token = "0x400C7A9")]
	[FieldOffset(Offset = "0x74")]
	protected Coroutine m_PlayGunResetAnimCoroutine;

	[Token(Token = "0x6009F58")]
	[Address(RVA = "0x1E76E80", Offset = "0x1E76E80", VA = "0x1E76E80")]
	public UIAvatar()
	{
	}

	[Token(Token = "0x6009F59")]
	[Address(RVA = "0x1E6A4D4", Offset = "0x1E6A4D4", VA = "0x1E6A4D4")]
	public bool IsCurrentModelFemale()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F5A")]
	[Address(RVA = "0x1E76F50", Offset = "0x1E76F50", VA = "0x1E76F50")]
	public static CSSharedAvatarData GetAvatarData(uint id)
	{
		return null;
	}

	[Token(Token = "0x6009F5B")]
	[Address(RVA = "0x1E77048", Offset = "0x1E77048", VA = "0x1E77048")]
	public static AvatarWardrobeData GetWardrobeData(uint id)
	{
		return null;
	}

	[Token(Token = "0x6009F5C")]
	[Address(RVA = "0x1E77140", Offset = "0x1E77140", VA = "0x1E77140")]
	public static string GetSlot(AvatarWardrobeData data)
	{
		return null;
	}

	[Token(Token = "0x6009F5D")]
	[Address(RVA = "0x1E7720C", Offset = "0x1E7720C", VA = "0x1E7720C")]
	public uint GetAvatarID()
	{
		return default(uint);
	}

	[Token(Token = "0x6009F5E")]
	[Address(RVA = "0x1E77264", Offset = "0x1E77264", VA = "0x1E77264")]
	internal void SetSlot(uint wId, bool isFemale, uint avatarId)
	{
	}

	[Token(Token = "0x6009F5F")]
	[Address(RVA = "0x1E772FC", Offset = "0x1E772FC", VA = "0x1E772FC")]
	internal void SetSlot(AvatarWardrobeData wData, bool isFemale, uint avatarId = 0u)
	{
	}

	[Token(Token = "0x6009F60")]
	[Address(RVA = "0x1E7743C", Offset = "0x1E7743C", VA = "0x1E7743C", Slot = "35")]
	internal virtual void SetAvatar(uint avatarId)
	{
	}

	[Token(Token = "0x6009F61")]
	[Address(RVA = "0x1E77608", Offset = "0x1E77608", VA = "0x1E77608", Slot = "36")]
	protected virtual void OnSetAvatar(CSSharedAvatarData aData)
	{
	}

	[Token(Token = "0x6009F62")]
	[Address(RVA = "0x1E77B14", Offset = "0x1E77B14", VA = "0x1E77B14", Slot = "28")]
	protected override void CharacterUpdateCallBack(UMAData data)
	{
	}

	[Token(Token = "0x6009F63")]
	[Address(RVA = "0x1E77C04", Offset = "0x1E77C04", VA = "0x1E77C04", Slot = "37")]
	protected virtual void OnSetAvatarDone(CSSharedAvatarData aData)
	{
	}

	[Token(Token = "0x6009F64")]
	[Address(RVA = "0x1E77754", Offset = "0x1E77754", VA = "0x1E77754")]
	protected void UpdateFaceSlots(CSSharedAvatarData aData)
	{
	}

	[Token(Token = "0x6009F65")]
	[Address(RVA = "0x1E77DD0", Offset = "0x1E77DD0", VA = "0x1E77DD0")]
	public void PlayLevelUpVfx()
	{
	}

	[Token(Token = "0x6009F66")]
	[Address(RVA = "0x1E77EDC", Offset = "0x1E77EDC", VA = "0x1E77EDC")]
	public void ClearLobbyAnimEffect()
	{
	}

	[Token(Token = "0x6009F67")]
	[Address(RVA = "0x1E77FD8", Offset = "0x1E77FD8", VA = "0x1E77FD8")]
	public void ForceSetColor(float f)
	{
	}

	[Token(Token = "0x6009F68")]
	[Address(RVA = "0x1E782BC", Offset = "0x1E782BC", VA = "0x1E782BC")]
	internal void SetColor(float f)
	{
	}

	[Token(Token = "0x6009F69")]
	[Address(RVA = "0x1E77A80", Offset = "0x1E77A80", VA = "0x1E77A80")]
	protected void SetDefaultColor(CSSharedAvatarData aData)
	{
	}

	[Token(Token = "0x6009F6A")]
	[Address(RVA = "0x1E78604", Offset = "0x1E78604", VA = "0x1E78604", Slot = "38")]
	public virtual void ResetAvatar()
	{
	}

	[Token(Token = "0x6009F6B")]
	[Address(RVA = "0x1E78660", Offset = "0x1E78660", VA = "0x1E78660")]
	public void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}
}
