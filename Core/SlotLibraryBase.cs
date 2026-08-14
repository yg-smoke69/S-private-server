using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Token(Token = "0x2003CBC")]
public abstract class SlotLibraryBase : MonoBehaviour
{
	[Token(Token = "0x60184D3")]
	[Address(RVA = "0x21D18C4", Offset = "0x21D18C4", VA = "0x21D18C4")]
	protected SlotLibraryBase()
	{
	}

	[Token(Token = "0x60184D4")]
	[Address(RVA = "0x21D2718", Offset = "0x21D2718", VA = "0x21D2718", Slot = "4")]
	public virtual void AddSlotAsset(SlotDataAsset slot)
	{
	}

	[Token(Token = "0x60184D5")]
	[Address(RVA = "0x21D27A0", Offset = "0x21D27A0", VA = "0x21D27A0", Slot = "5")]
	public virtual SlotDataAsset[] GetAllSlotAssets()
	{
		return null;
	}

	[Token(Token = "0x60184D6")]
	public abstract SlotData InstantiateSlot(string name);

	[Token(Token = "0x60184D7")]
	public abstract SlotData InstantiateSlot(int nameHash);

	[Token(Token = "0x60184D8")]
	public abstract SlotData InstantiateSlot(string name, List<OverlayData> overlayList);

	[Token(Token = "0x60184D9")]
	public abstract SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList);

	[Token(Token = "0x60184DA")]
	[Address(RVA = "0x21D2828", Offset = "0x21D2828", VA = "0x21D2828", Slot = "10")]
	public virtual bool HasSlot(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60184DB")]
	[Address(RVA = "0x21D28B0", Offset = "0x21D28B0", VA = "0x21D28B0", Slot = "11")]
	public virtual bool HasSlot(int nameHash)
	{
		return default(bool);
	}

	[Token(Token = "0x60184DC")]
	[Address(RVA = "0x21D2938", Offset = "0x21D2938", VA = "0x21D2938", Slot = "12")]
	public virtual SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x60184DD")]
	public abstract void UpdateDictionary();

	[Token(Token = "0x60184DE")]
	public abstract void ValidateDictionary();
}
