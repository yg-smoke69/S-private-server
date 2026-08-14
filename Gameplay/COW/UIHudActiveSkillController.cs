using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026CF")]
internal class UIHudActiveSkillController : UIHudButtonBaseController
{
	[Token(Token = "0x400EFD3")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudActiveSkillView m_View;

	[Token(Token = "0x400EFD4")]
	[FieldOffset(Offset = "0x30")]
	private PFLCPEHBBLN m_ActiveSkill;

	[Token(Token = "0x400EFD5")]
	[FieldOffset(Offset = "0x34")]
	private NetworkPet m_LocalPet;

	[Token(Token = "0x400EFD6")]
	[FieldOffset(Offset = "0x38")]
	private float m_BanSkillTime;

	[Token(Token = "0x400EFD7")]
	[FieldOffset(Offset = "0x3C")]
	private float m_StartBanTime;

	[Token(Token = "0x400EFD8")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsSkillBanned;

	[Token(Token = "0x400EFD9")]
	[FieldOffset(Offset = "0x44")]
	private string m_StrButtonAction;

	[Token(Token = "0x400EFDA")]
	[FieldOffset(Offset = "0x48")]
	private float multiscale;

	[Token(Token = "0x400EFDB")]
	[FieldOffset(Offset = "0x4C")]
	private float m_BGRangeRadius;

	[Token(Token = "0x400EFDC")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_DefaultPos;

	[Token(Token = "0x400EFDD")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsDragBtn;

	[Token(Token = "0x400EFDE")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_IsThrowSkillLineOn;

	[Token(Token = "0x400EFDF")]
	[FieldOffset(Offset = "0x60")]
	private List<GameObject> m_PetSkillAnimationGameObject;

	[Token(Token = "0x400EFE0")]
	[FieldOffset(Offset = "0x64")]
	private int m_lastCanUsePhaseCount;

	[Token(Token = "0x600EAB1")]
	[Address(RVA = "0x16FF1F8", Offset = "0x16FF1F8", VA = "0x16FF1F8")]
	public UIHudActiveSkillController()
	{
	}

	[Token(Token = "0x600EAB2")]
	[Address(RVA = "0x16FF274", Offset = "0x16FF274", VA = "0x16FF274")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EAB3")]
	[Address(RVA = "0x16FF318", Offset = "0x16FF318", VA = "0x16FF318", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EAB4")]
	[Address(RVA = "0x16FFB3C", Offset = "0x16FFB3C", VA = "0x16FFB3C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EAB5")]
	[Address(RVA = "0x1700008", Offset = "0x1700008", VA = "0x1700008", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EAB6")]
	[Address(RVA = "0x1700060", Offset = "0x1700060", VA = "0x1700060", Slot = "24")]
	protected override void RefreshVisibility()
	{
	}

	[Token(Token = "0x600EAB7")]
	[Address(RVA = "0x17002F4", Offset = "0x17002F4", VA = "0x17002F4")]
	public void ShowActiveSkill(object[] param)
	{
	}

	[Token(Token = "0x600EAB8")]
	[Address(RVA = "0x170093C", Offset = "0x170093C", VA = "0x170093C")]
	public void OnAddLocalPlayer(object[] param)
	{
	}

	[Token(Token = "0x600EAB9")]
	[Address(RVA = "0x1700A1C", Offset = "0x1700A1C", VA = "0x1700A1C")]
	public void SetActiveSkill(object[] param)
	{
	}

	[Token(Token = "0x600EABA")]
	[Address(RVA = "0x1700A84", Offset = "0x1700A84", VA = "0x1700A84")]
	private void HideActiveSkill(object[] param)
	{
	}

	[Token(Token = "0x600EABB")]
	[Address(RVA = "0x17003F0", Offset = "0x17003F0", VA = "0x17003F0")]
	public void ShowActiveSkill()
	{
	}

	[Token(Token = "0x600EABC")]
	[Address(RVA = "0x1700CE8", Offset = "0x1700CE8", VA = "0x1700CE8")]
	private void SetEnhanced(uint skillLevel)
	{
	}

	[Token(Token = "0x600EABD")]
	[Address(RVA = "0x1700D88", Offset = "0x1700D88", VA = "0x1700D88")]
	private void OnAddLocalPet(object[] param)
	{
	}

	[Token(Token = "0x600EABE")]
	[Address(RVA = "0x1700EFC", Offset = "0x1700EFC", VA = "0x1700EFC")]
	private void OnChangActiveSkillState(object[] param)
	{
	}

	[Token(Token = "0x600EABF")]
	[Address(RVA = "0x17010FC", Offset = "0x17010FC", VA = "0x17010FC")]
	private void UpdateBannedState()
	{
	}

	[Token(Token = "0x600EAC0")]
	[Address(RVA = "0x1701210", Offset = "0x1701210", VA = "0x1701210")]
	public float BanSkillProgress()
	{
		return default(float);
	}

	[Token(Token = "0x600EAC1")]
	[Address(RVA = "0x170130C", Offset = "0x170130C", VA = "0x170130C")]
	private void OnUpdateSkillIcon(object[] param)
	{
	}

	[Token(Token = "0x600EAC2")]
	[Address(RVA = "0x1700AF8", Offset = "0x1700AF8", VA = "0x1700AF8")]
	protected void UpdateIcon()
	{
	}

	[Token(Token = "0x600EAC3")]
	[Address(RVA = "0x1701374", Offset = "0x1701374", VA = "0x1701374")]
	protected void Update()
	{
	}

	[Token(Token = "0x600EAC4")]
	[Address(RVA = "0x17026C4", Offset = "0x17026C4", VA = "0x17026C4")]
	private void OnMiniPhaseChanged(object[] data)
	{
	}

	[Token(Token = "0x600EAC5")]
	[Address(RVA = "0x1702428", Offset = "0x1702428", VA = "0x1702428")]
	private void ShowPetSkillAnim(bool show)
	{
	}

	[Token(Token = "0x600EAC6")]
	[Address(RVA = "0x17027C0", Offset = "0x17027C0", VA = "0x17027C0")]
	private void OnMiniGameStart(object[] data)
	{
	}

	[Token(Token = "0x600EAC7")]
	[Address(RVA = "0x17028C0", Offset = "0x17028C0", VA = "0x17028C0")]
	private void OnMiniGameClose(object[] data)
	{
	}

	[Token(Token = "0x600EAC8")]
	[Address(RVA = "0x17000CC", Offset = "0x17000CC", VA = "0x17000CC")]
	private void ResetDragBtn()
	{
	}

	[Token(Token = "0x600EAC9")]
	[Address(RVA = "0x1702940", Offset = "0x1702940", VA = "0x1702940")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EACA")]
	[Address(RVA = "0x1702948", Offset = "0x1702948", VA = "0x1702948")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EACB")]
	[Address(RVA = "0x1702950", Offset = "0x1702950", VA = "0x1702950")]
	public void _003C_003EiFixBaseProxy_RefreshVisibility()
	{
	}
}
