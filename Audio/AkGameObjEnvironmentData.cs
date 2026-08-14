using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E23")]
public class AkGameObjEnvironmentData
{
	[Token(Token = "0x401A51B")]
	[FieldOffset(Offset = "0x8")]
	private readonly List<AkEnvironment> activeEnvironments;

	[Token(Token = "0x401A51C")]
	[FieldOffset(Offset = "0xC")]
	private readonly List<AkEnvironment> activeEnvironmentsFromPortals;

	[Token(Token = "0x401A51D")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<AkEnvironmentPortal> activePortals;

	[Token(Token = "0x401A51E")]
	[FieldOffset(Offset = "0x14")]
	private readonly AkAuxSendArray auxSendValues;

	[Token(Token = "0x401A51F")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 lastPosition;

	[Token(Token = "0x401A520")]
	[FieldOffset(Offset = "0x24")]
	private bool hasEnvironmentListChanged;

	[Token(Token = "0x401A521")]
	[FieldOffset(Offset = "0x25")]
	private bool hasActivePortalListChanged;

	[Token(Token = "0x401A522")]
	[FieldOffset(Offset = "0x26")]
	private bool hasSentZero;

	[Token(Token = "0x6019436")]
	[Address(RVA = "0x35D99EC", Offset = "0x35D99EC", VA = "0x35D99EC")]
	public AkGameObjEnvironmentData()
	{
	}

	[Token(Token = "0x6019437")]
	[Address(RVA = "0x35DA7D0", Offset = "0x35DA7D0", VA = "0x35DA7D0")]
	private void AddHighestPriorityEnvironmentsFromPortals(Vector3 position)
	{
	}

	[Token(Token = "0x6019438")]
	[Address(RVA = "0x35DAC98", Offset = "0x35DAC98", VA = "0x35DAC98")]
	private void AddHighestPriorityEnvironments(Vector3 position)
	{
	}

	[Token(Token = "0x6019439")]
	[Address(RVA = "0x35D9CC8", Offset = "0x35D9CC8", VA = "0x35D9CC8")]
	public void UpdateAuxSend(GameObject gameObject, Vector3 position)
	{
	}

	[Token(Token = "0x601943A")]
	[Address(RVA = "0x35DAE8C", Offset = "0x35DAE8C", VA = "0x35DAE8C")]
	private void TryAddEnvironment(AkEnvironment env)
	{
	}

	[Token(Token = "0x601943B")]
	[Address(RVA = "0x35DB098", Offset = "0x35DB098", VA = "0x35DB098")]
	private void RemoveEnvironment(AkEnvironment env)
	{
	}

	[Token(Token = "0x601943C")]
	[Address(RVA = "0x35D9B38", Offset = "0x35D9B38", VA = "0x35D9B38")]
	public void AddAkEnvironment(Collider environmentCollider, Collider gameObjectCollider)
	{
	}

	[Token(Token = "0x601943D")]
	[Address(RVA = "0x35DB150", Offset = "0x35DB150", VA = "0x35DB150")]
	private bool AkEnvironmentBelongsToActivePortals(AkEnvironment env)
	{
		return default(bool);
	}

	[Token(Token = "0x601943E")]
	[Address(RVA = "0x35DA4B8", Offset = "0x35DA4B8", VA = "0x35DA4B8")]
	public void RemoveAkEnvironment(Collider environmentCollider, Collider gameObjectCollider)
	{
	}
}
