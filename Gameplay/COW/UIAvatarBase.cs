using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FCF")]
public class UIAvatarBase : Entity
{
	[Token(Token = "0x2001FD0")]
	private sealed class _003CWaitUntilNotDirtyEnum_003Ec__Iterator0<T> : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C79C")]
		[FieldOffset(Offset = "0x0")]
		internal Action<T> callback;

		[Token(Token = "0x400C79D")]
		[FieldOffset(Offset = "0x0")]
		internal T t;

		[Token(Token = "0x400C79E")]
		[FieldOffset(Offset = "0x0")]
		internal UIAvatarBase _0024this;

		[Token(Token = "0x400C79F")]
		[FieldOffset(Offset = "0x0")]
		internal object _0024current;

		[Token(Token = "0x400C7A0")]
		[FieldOffset(Offset = "0x0")]
		internal bool _0024disposing;

		[Token(Token = "0x400C7A1")]
		[FieldOffset(Offset = "0x0")]
		internal int _0024PC;

		[Token(Token = "0x17000FB0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009F54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FB1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009F55")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009F52")]
		public _003CWaitUntilNotDirtyEnum_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009F53")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009F56")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009F57")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C78B")]
	[FieldOffset(Offset = "0x34")]
	public SharedColorTable SkinColor;

	[Token(Token = "0x400C78C")]
	[FieldOffset(Offset = "0x38")]
	protected IUmaAvatar m_Avatar;

	[Token(Token = "0x400C78D")]
	[FieldOffset(Offset = "0x3C")]
	protected GameObject m_AvatarGo;

	[Token(Token = "0x400C78E")]
	[FieldOffset(Offset = "0x40")]
	public LobbyAvatarClothEffectComponent m_ClothEffectComponent;

	[Token(Token = "0x400C78F")]
	[FieldOffset(Offset = "0x44")]
	public MaterialAnimComponent m_MaterialAnimComponent;

	[Token(Token = "0x400C790")]
	[FieldOffset(Offset = "0x48")]
	protected AvatarEffect m_AvatarEffect;

	[Token(Token = "0x400C791")]
	[FieldOffset(Offset = "0x4C")]
	protected bool m_IsLocalAvatar;

	[Token(Token = "0x400C792")]
	[FieldOffset(Offset = "0x4D")]
	protected bool m_AvatarReady;

	[Token(Token = "0x400C793")]
	[FieldOffset(Offset = "0x4E")]
	protected bool m_AvatarCreated;

	[Token(Token = "0x400C794")]
	[FieldOffset(Offset = "0x4F")]
	protected bool m_PendingChangesForBuild;

	[Token(Token = "0x400C795")]
	[FieldOffset(Offset = "0x50")]
	protected bool m_HidingSkinRender;

	[Token(Token = "0x400C796")]
	[FieldOffset(Offset = "0x51")]
	protected bool m_IsPreviewAvatar;

	[Token(Token = "0x400C797")]
	[FieldOffset(Offset = "0x52")]
	protected bool m_HasUpdateCallback;

	[Token(Token = "0x400C798")]
	[FieldOffset(Offset = "0x53")]
	protected bool m_PlayEmoteBGMLoop;

	[Token(Token = "0x400C799")]
	[FieldOffset(Offset = "0x54")]
	protected AudioResource m_AudioRes;

	[Token(Token = "0x400C79A")]
	[FieldOffset(Offset = "0x58")]
	public bool SkipInitBuild;

	[Token(Token = "0x400C79B")]
	[FieldOffset(Offset = "0x5C")]
	protected string m_backpackSlot;

	[Token(Token = "0x17000FAE")]
	public bool IsLocalAvatar
	{
		[Token(Token = "0x6009F38")]
		[Address(RVA = "0x1E87B68", Offset = "0x1E87B68", VA = "0x1E87B68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000FAF")]
	public bool IsPreviewAvatar
	{
		[Token(Token = "0x6009F39")]
		[Address(RVA = "0x1E87BC0", Offset = "0x1E87BC0", VA = "0x1E87BC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6009F37")]
	[Address(RVA = "0x1E76E84", Offset = "0x1E76E84", VA = "0x1E76E84")]
	public UIAvatarBase()
	{
	}

	[Token(Token = "0x6009F3A")]
	[Address(RVA = "0x1E87C18", Offset = "0x1E87C18", VA = "0x1E87C18")]
	private void InitRecipeDic()
	{
	}

	[Token(Token = "0x6009F3B")]
	[Address(RVA = "0x1E87C6C", Offset = "0x1E87C6C", VA = "0x1E87C6C", Slot = "24")]
	public virtual void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1)
	{
	}

	[Token(Token = "0x6009F3C")]
	[Address(RVA = "0x1E888BC", Offset = "0x1E888BC", VA = "0x1E888BC")]
	public void HideRender(bool visble = false)
	{
	}

	[Token(Token = "0x6009F3D")]
	[Address(RVA = "0x1E88A08", Offset = "0x1E88A08", VA = "0x1E88A08", Slot = "25")]
	protected virtual void OnInitAvatarBeforeBuild(bool isLocal)
	{
	}

	[Token(Token = "0x6009F3E")]
	[Address(RVA = "0x1E88A64", Offset = "0x1E88A64", VA = "0x1E88A64", Slot = "26")]
	protected virtual void CharacterCreatedCallback(UMAData umaData)
	{
	}

	[Token(Token = "0x6009F3F")]
	[Address(RVA = "0x1E88C8C", Offset = "0x1E88C8C", VA = "0x1E88C8C")]
	private void OnCharacterReady(UMAData umaData)
	{
	}

	[Token(Token = "0x6009F40")]
	[Address(RVA = "0x1E88EE4", Offset = "0x1E88EE4", VA = "0x1E88EE4", Slot = "27")]
	protected virtual void OnInitAvatarAfterBuild(bool isLocal)
	{
	}

	[Token(Token = "0x6009F41")]
	[Address(RVA = "0x1E77BA8", Offset = "0x1E77BA8", VA = "0x1E77BA8", Slot = "28")]
	protected virtual void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	[Token(Token = "0x6009F42")]
	protected IEnumerator WaitUntilNotDirty<T>(Action<T> callback, T t)
	{
		return null;
	}

	[Token(Token = "0x6009F43")]
	private IEnumerator WaitUntilNotDirtyEnum<T>(Action<T> callback, T t)
	{
		return null;
	}

	[Token(Token = "0x6009F44")]
	[Address(RVA = "0x1E88F40", Offset = "0x1E88F40", VA = "0x1E88F40")]
	private bool IsUmaContextDestroyed()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F45")]
	[Address(RVA = "0x1E89028", Offset = "0x1E89028", VA = "0x1E89028", Slot = "29")]
	internal virtual void SetSlot(string recipe)
	{
	}

	[Token(Token = "0x6009F46")]
	[Address(RVA = "0x1E8920C", Offset = "0x1E8920C", VA = "0x1E8920C", Slot = "30")]
	internal virtual void ClearSlot(string slot)
	{
	}

	[Token(Token = "0x6009F47")]
	[Address(RVA = "0x1E89350", Offset = "0x1E89350", VA = "0x1E89350", Slot = "31")]
	protected virtual void ClearAllSlots()
	{
	}

	[Token(Token = "0x6009F48")]
	[Address(RVA = "0x1E894D0", Offset = "0x1E894D0", VA = "0x1E894D0", Slot = "32")]
	protected virtual void ClearClothesSlots()
	{
	}

	[Token(Token = "0x6009F49")]
	[Address(RVA = "0x1E77C68", Offset = "0x1E77C68", VA = "0x1E77C68")]
	protected void ClearSlotRaw(UIModelAvatarBase.EWardrobeType t)
	{
	}

	[Token(Token = "0x6009F4A")]
	[Address(RVA = "0x1E89570", Offset = "0x1E89570", VA = "0x1E89570", Slot = "33")]
	protected virtual void ChangeRace(string race)
	{
	}

	[Token(Token = "0x6009F4B")]
	[Address(RVA = "0x1E783F8", Offset = "0x1E783F8", VA = "0x1E783F8")]
	protected void SetColor(Color c)
	{
	}

	[Token(Token = "0x6009F4C")]
	[Address(RVA = "0x1E896A0", Offset = "0x1E896A0", VA = "0x1E896A0", Slot = "34")]
	protected virtual void BuildAndUpdateAvatar()
	{
	}

	[Token(Token = "0x6009F4D")]
	[Address(RVA = "0x1E898CC", Offset = "0x1E898CC", VA = "0x1E898CC")]
	public void BuildIfChanged()
	{
	}

	[Token(Token = "0x6009F4E")]
	[Address(RVA = "0x1E89944", Offset = "0x1E89944", VA = "0x1E89944")]
	public void WaitBuildSync(bool removeNonDirty = true)
	{
	}

	[Token(Token = "0x6009F4F")]
	[Address(RVA = "0x1E89BC4", Offset = "0x1E89BC4", VA = "0x1E89BC4")]
	public bool IsAvatarDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F50")]
	[Address(RVA = "0x1E89CFC", Offset = "0x1E89CFC", VA = "0x1E89CFC")]
	public void HidekinMeshRenderer(bool b)
	{
	}

	[Token(Token = "0x6009F51")]
	[Address(RVA = "0x1E8A080", Offset = "0x1E8A080", VA = "0x1E8A080")]
	public void SetCharacterAway(bool isaway)
	{
	}
}
