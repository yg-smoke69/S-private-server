using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UMACharacterSystem;
using UnityEngine;

[Token(Token = "0x2003CAA")]
public class UMAContext : MonoBehaviour
{
	[Token(Token = "0x4019C63")]
	[FieldOffset(Offset = "0xC")]
	public DynamicCharacterSystemBase dynamicCharacterSystem;

	[Token(Token = "0x4019C64")]
	[FieldOffset(Offset = "0x0")]
	public static UMAContext Instance;

	[Token(Token = "0x4019C65")]
	[FieldOffset(Offset = "0x10")]
	public RaceLibraryBase raceLibrary;

	[Token(Token = "0x4019C66")]
	[FieldOffset(Offset = "0x14")]
	public SlotLibraryBase slotLibrary;

	[Token(Token = "0x4019C67")]
	[FieldOffset(Offset = "0x18")]
	public OverlayLibraryBase overlayLibrary;

	[Token(Token = "0x601842F")]
	[Address(RVA = "0x2A59B40", Offset = "0x2A59B40", VA = "0x2A59B40")]
	public UMAContext()
	{
	}

	[Token(Token = "0x6018430")]
	[Address(RVA = "0x2A59B48", Offset = "0x2A59B48", VA = "0x2A59B48", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6018431")]
	[Address(RVA = "0x2A59D50", Offset = "0x2A59D50", VA = "0x2A59D50", Slot = "5")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6018432")]
	[Address(RVA = "0x2A59E14", Offset = "0x2A59E14", VA = "0x2A59E14")]
	public void ValidateDictionaries()
	{
	}

	[Token(Token = "0x6018433")]
	[Address(RVA = "0x2A59E9C", Offset = "0x2A59E9C", VA = "0x2A59E9C", Slot = "6")]
	public virtual RaceData GetRace(string name)
	{
		return null;
	}

	[Token(Token = "0x6018434")]
	[Address(RVA = "0x2A59ED8", Offset = "0x2A59ED8", VA = "0x2A59ED8")]
	public RaceData GetRace(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x6018435")]
	[Address(RVA = "0x2A59F14", Offset = "0x2A59F14", VA = "0x2A59F14", Slot = "7")]
	public virtual SlotData InstantiateSlot(string name)
	{
		return null;
	}

	[Token(Token = "0x6018436")]
	[Address(RVA = "0x2A59F50", Offset = "0x2A59F50", VA = "0x2A59F50", Slot = "8")]
	public virtual SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x6018437")]
	[Address(RVA = "0x2A59F8C", Offset = "0x2A59F8C", VA = "0x2A59F8C")]
	public SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	[Token(Token = "0x6018438")]
	[Address(RVA = "0x2A59FD0", Offset = "0x2A59FD0", VA = "0x2A59FD0")]
	public SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	[Token(Token = "0x6018439")]
	[Address(RVA = "0x2A5A014", Offset = "0x2A5A014", VA = "0x2A5A014", Slot = "9")]
	public virtual OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	[Token(Token = "0x601843A")]
	[Address(RVA = "0x2A5A050", Offset = "0x2A5A050", VA = "0x2A5A050", Slot = "10")]
	public virtual OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x601843B")]
	[Address(RVA = "0x2A5A08C", Offset = "0x2A5A08C", VA = "0x2A5A08C")]
	public OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	[Token(Token = "0x601843C")]
	[Address(RVA = "0x2A5A0F4", Offset = "0x2A5A0F4", VA = "0x2A5A0F4")]
	public OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	[Token(Token = "0x601843D")]
	[Address(RVA = "0x2A5A15C", Offset = "0x2A5A15C", VA = "0x2A5A15C")]
	public static UMAContext FindInstance()
	{
		return null;
	}
}
