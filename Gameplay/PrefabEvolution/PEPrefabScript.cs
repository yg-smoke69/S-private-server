using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PrefabEvolution;

[Token(Token = "0x2003BB4")]
public class PEPrefabScript : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2003BB5")]
	public static class EditorBridge
	{
		[Token(Token = "0x4019699")]
		[FieldOffset(Offset = "0x0")]
		public static Action<PEPrefabScript> OnValidate;

		[Token(Token = "0x401969A")]
		[FieldOffset(Offset = "0x4")]
		public static Func<GameObject, string> GetAssetGuid;

		[Token(Token = "0x401969B")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, GameObject> GetAssetByGuid;
	}

	[Token(Token = "0x2003BB6")]
	private class PrefabInternalData
	{
		[Token(Token = "0x401969C")]
		[FieldOffset(Offset = "0x8")]
		private readonly PEExposedProperties Properties;

		[Token(Token = "0x401969D")]
		[FieldOffset(Offset = "0xC")]
		private readonly PELinkage Links;

		[Token(Token = "0x401969E")]
		[FieldOffset(Offset = "0x10")]
		private readonly PEModifications Modifications;

		[Token(Token = "0x401969F")]
		[FieldOffset(Offset = "0x14")]
		private readonly string ParentPrefabGUID;

		[Token(Token = "0x40196A0")]
		[FieldOffset(Offset = "0x18")]
		private readonly string PrefabGUID;

		[Token(Token = "0x6017D18")]
		[Address(RVA = "0x1E2F0BC", Offset = "0x1E2F0BC", VA = "0x1E2F0BC")]
		public PrefabInternalData(PEPrefabScript script)
		{
		}

		[Token(Token = "0x6017D19")]
		[Address(RVA = "0x1E2F164", Offset = "0x1E2F164", VA = "0x1E2F164")]
		public void Fill(PEPrefabScript script)
		{
		}
	}

	[Token(Token = "0x4019692")]
	[FieldOffset(Offset = "0xC")]
	public PEExposedProperties Properties;

	[Token(Token = "0x4019693")]
	[FieldOffset(Offset = "0x10")]
	public PELinkage Links;

	[Token(Token = "0x4019694")]
	[FieldOffset(Offset = "0x14")]
	public PEModifications Modifications;

	[Token(Token = "0x4019695")]
	[FieldOffset(Offset = "0x18")]
	public string ParentPrefabGUID;

	[Token(Token = "0x4019696")]
	[FieldOffset(Offset = "0x1C")]
	public string PrefabGUID;

	[Token(Token = "0x4019697")]
	[FieldOffset(Offset = "0x20")]
	private PrefabInternalData _prefabInternalData;

	[Token(Token = "0x170018BE")]
	public GameObject ParentPrefab
	{
		[Token(Token = "0x6017D0D")]
		[Address(RVA = "0x1E2D3F8", Offset = "0x1E2D3F8", VA = "0x1E2D3F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017D0E")]
		[Address(RVA = "0x1E2EB54", Offset = "0x1E2EB54", VA = "0x1E2EB54")]
		set
		{
		}
	}

	[Token(Token = "0x170018BF")]
	public GameObject Prefab
	{
		[Token(Token = "0x6017D0F")]
		[Address(RVA = "0x1E2EC2C", Offset = "0x1E2EC2C", VA = "0x1E2EC2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017D10")]
		[Address(RVA = "0x1E2ECC0", Offset = "0x1E2ECC0", VA = "0x1E2ECC0")]
		set
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action OnBuildModifications
	{
		[Token(Token = "0x6017D12")]
		[Address(RVA = "0x1E2EE1C", Offset = "0x1E2EE1C", VA = "0x1E2EE1C")]
		add
		{
		}
		[Token(Token = "0x6017D13")]
		[Address(RVA = "0x1E2EF28", Offset = "0x1E2EF28", VA = "0x1E2EF28")]
		remove
		{
		}
	}

	[Token(Token = "0x6017D0C")]
	[Address(RVA = "0x1E2A55C", Offset = "0x1E2A55C", VA = "0x1E2A55C")]
	public PEPrefabScript()
	{
	}

	[Token(Token = "0x6017D11")]
	[Address(RVA = "0x1E2ED98", Offset = "0x1E2ED98", VA = "0x1E2ED98")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6017D14")]
	[Address(RVA = "0x1E2F034", Offset = "0x1E2F034", VA = "0x1E2F034")]
	public void InvokeOnBuildModifications()
	{
	}

	[Token(Token = "0x6017D15")]
	[Address(RVA = "0x1E2F048", Offset = "0x1E2F048", VA = "0x1E2F048", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6017D16")]
	[Address(RVA = "0x1E2F04C", Offset = "0x1E2F04C", VA = "0x1E2F04C", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6017D17")]
	[Address(RVA = "0x1E2F050", Offset = "0x1E2F050", VA = "0x1E2F050")]
	private void ClearInternalData()
	{
	}
}
