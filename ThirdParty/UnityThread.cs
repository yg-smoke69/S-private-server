using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004023")]
public class UnityThread : MonoBehaviour
{
	[Token(Token = "0x401AFDF")]
	[FieldOffset(Offset = "0x0")]
	private static UnityThread _I;

	[Token(Token = "0x401AFE0")]
	[FieldOffset(Offset = "0x4")]
	private static List<Action> _UpdateActionsPending;

	[Token(Token = "0x401AFE1")]
	[FieldOffset(Offset = "0xC")]
	private List<Action> _UpdateActionsExecuting;

	[Token(Token = "0x401AFE2")]
	[FieldOffset(Offset = "0x8")]
	private static bool _HasUpdateActions;

	[Token(Token = "0x601A1DE")]
	[Address(RVA = "0x2A688D4", Offset = "0x2A688D4", VA = "0x2A688D4")]
	public UnityThread()
	{
	}

	[Token(Token = "0x601A1DF")]
	[Address(RVA = "0x2A68960", Offset = "0x2A68960", VA = "0x2A68960")]
	public static void Init(bool visible = false)
	{
	}

	[Token(Token = "0x601A1E0")]
	[Address(RVA = "0x2A68B48", Offset = "0x2A68B48", VA = "0x2A68B48")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A1E1")]
	[Address(RVA = "0x2A68BDC", Offset = "0x2A68BDC", VA = "0x2A68BDC")]
	public static void RunInUpdate(Action action)
	{
	}

	[Token(Token = "0x601A1E2")]
	[Address(RVA = "0x2A68D68", Offset = "0x2A68D68", VA = "0x2A68D68")]
	private void Update()
	{
	}

	[Token(Token = "0x601A1E3")]
	[Address(RVA = "0x2A690E0", Offset = "0x2A690E0", VA = "0x2A690E0")]
	private void OnApplicationQuit()
	{
	}
}
