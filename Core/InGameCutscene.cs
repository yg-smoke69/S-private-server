using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000447")]
public class InGameCutscene : MonoBehaviour
{
	[Token(Token = "0x2000448")]
	public delegate void OnFinished(InGameCutscene cutscene);

	[Token(Token = "0x4003C42")]
	[FieldOffset(Offset = "0xC")]
	public bool IsLoop;

	[Token(Token = "0x4003C43")]
	[FieldOffset(Offset = "0x10")]
	public float m_TotalTime;

	[Token(Token = "0x4003C44")]
	[FieldOffset(Offset = "0x14")]
	public Animator TimeLineAnimator;

	[Token(Token = "0x4003C45")]
	[FieldOffset(Offset = "0x18")]
	public bool IsUseCutsceneCamera;

	[Token(Token = "0x4003C46")]
	[FieldOffset(Offset = "0x19")]
	public bool m_IsHideHUD;

	[Token(Token = "0x4003C47")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_AnimPrefab;

	[Token(Token = "0x4003C48")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsFinishDestory;

	[Token(Token = "0x4003C49")]
	[FieldOffset(Offset = "0x24")]
	public List<GameObject> m_GameObjectKeepInScene;

	[Token(Token = "0x4003C4A")]
	[FieldOffset(Offset = "0x28")]
	public List<BlackMaskConfig> m_BlackMaskConfig;

	[Token(Token = "0x4003C4B")]
	[FieldOffset(Offset = "0x2C")]
	public string AnimPrefebResourceID;

	[Token(Token = "0x4003C4C")]
	[FieldOffset(Offset = "0x30")]
	public OnFinished deleg_OnFinished;

	[Token(Token = "0x4003C4D")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasBegun;

	[Token(Token = "0x4003C4E")]
	[FieldOffset(Offset = "0x38")]
	private float m_BeginPlayTime;

	[Token(Token = "0x4003C4F")]
	[FieldOffset(Offset = "0x3C")]
	private UICutsceneBlackMask m_BlackMaskUI;

	[Token(Token = "0x4003C50")]
	[FieldOffset(Offset = "0x40")]
	private int curBlackMaskIndex;

	[Token(Token = "0x600155F")]
	[Address(RVA = "0x31093FC", Offset = "0x31093FC", VA = "0x31093FC")]
	public InGameCutscene()
	{
	}

	[Token(Token = "0x6001560")]
	[Address(RVA = "0x31094CC", Offset = "0x31094CC", VA = "0x31094CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001561")]
	[Address(RVA = "0x3109568", Offset = "0x3109568", VA = "0x3109568")]
	public void LoadAnimPrefeb()
	{
	}

	[Token(Token = "0x6001562")]
	[Address(RVA = "0x3109954", Offset = "0x3109954", VA = "0x3109954")]
	public void UnLoadAnimPrefeb()
	{
	}

	[Token(Token = "0x6001563")]
	[Address(RVA = "0x3109B30", Offset = "0x3109B30", VA = "0x3109B30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001564")]
	[Address(RVA = "0x3109B34", Offset = "0x3109B34", VA = "0x3109B34")]
	public void PlayCutscene()
	{
	}

	[Token(Token = "0x6001565")]
	[Address(RVA = "0x3109B74", Offset = "0x3109B74", VA = "0x3109B74")]
	private void ReCalculateCutsceneTime()
	{
	}

	[Token(Token = "0x6001566")]
	[Address(RVA = "0x310A06C", Offset = "0x310A06C", VA = "0x310A06C")]
	public void OnCutsceneFinish()
	{
	}

	[Token(Token = "0x6001567")]
	[Address(RVA = "0x310A098", Offset = "0x310A098", VA = "0x310A098")]
	public void StopCutscene()
	{
	}

	[Token(Token = "0x6001568")]
	[Address(RVA = "0x310A878", Offset = "0x310A878", VA = "0x310A878")]
	private void Update()
	{
	}

	[Token(Token = "0x6001569")]
	[Address(RVA = "0x3109D70", Offset = "0x3109D70", VA = "0x3109D70")]
	private void OnCutsceneBegin()
	{
	}

	[Token(Token = "0x600156A")]
	[Address(RVA = "0x310A790", Offset = "0x310A790", VA = "0x310A790")]
	private void NotifyLocalplayerInCutscene(bool isInCutscene)
	{
	}

	[Token(Token = "0x600156B")]
	[Address(RVA = "0x310A8DC", Offset = "0x310A8DC", VA = "0x310A8DC", Slot = "4")]
	public virtual void UpdateBlackMask()
	{
	}
}
