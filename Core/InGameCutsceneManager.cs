using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000449")]
public class InGameCutsceneManager : MonoBehaviour
{
	[Token(Token = "0x4003C51")]
	[FieldOffset(Offset = "0xC")]
	public List<InGameCutscene> m_CutsceneList;

	[Token(Token = "0x4003C52")]
	[FieldOffset(Offset = "0x10")]
	private Transform KeepInSceneRoot;

	[Token(Token = "0x4003C53")]
	[FieldOffset(Offset = "0x14")]
	public Action m_CurFinishCallBack;

	[Token(Token = "0x4003C54")]
	[FieldOffset(Offset = "0x18")]
	public int m_CurCutsceneIndex;

	[Token(Token = "0x6001570")]
	[Address(RVA = "0x310AAF0", Offset = "0x310AAF0", VA = "0x310AAF0")]
	public InGameCutsceneManager()
	{
	}

	[Token(Token = "0x6001571")]
	[Address(RVA = "0x310AB84", Offset = "0x310AB84", VA = "0x310AB84")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6001572")]
	[Address(RVA = "0x310AE54", Offset = "0x310AE54", VA = "0x310AE54")]
	public void Start()
	{
	}

	[Token(Token = "0x6001573")]
	[Address(RVA = "0x310AE58", Offset = "0x310AE58", VA = "0x310AE58")]
	private void RegisterToMatchGame()
	{
	}

	[Token(Token = "0x6001574")]
	[Address(RVA = "0x310AEDC", Offset = "0x310AEDC", VA = "0x310AEDC", Slot = "4")]
	public virtual bool PlayCutscene(int index, [Optional] Action OnCutsceneFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x6001575")]
	[Address(RVA = "0x310B0E8", Offset = "0x310B0E8", VA = "0x310B0E8")]
	public bool PlayCutscene(int index, Vector3 pos, Quaternion rot, [Optional] Action OnCutsceneFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x6001576")]
	[Address(RVA = "0x310B370", Offset = "0x310B370", VA = "0x310B370")]
	public void StopCutscene(bool isCallFinishCallback = true)
	{
	}

	[Token(Token = "0x6001577")]
	[Address(RVA = "0x310B538", Offset = "0x310B538", VA = "0x310B538", Slot = "5")]
	public virtual void ProcessCustsceneFinishOrStoped(InGameCutscene FinishedCutscene)
	{
	}

	[Token(Token = "0x6001578")]
	[Address(RVA = "0x310B880", Offset = "0x310B880", VA = "0x310B880", Slot = "6")]
	public virtual void OnCutsceneFinish(InGameCutscene FinishedCutscene)
	{
	}
}
