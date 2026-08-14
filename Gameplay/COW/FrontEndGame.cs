using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C60")]
internal class FrontEndGame : COWGameBase
{
	[Token(Token = "0x2002C61")]
	private sealed class _003COnPreprocessFinished_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010ECE")]
		[FieldOffset(Offset = "0x8")]
		internal object _0024current;

		[Token(Token = "0x4010ECF")]
		[FieldOffset(Offset = "0xC")]
		internal bool _0024disposing;

		[Token(Token = "0x4010ED0")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x1700132E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012861")]
			[Address(RVA = "0xDFA124", Offset = "0xDFA124", VA = "0xDFA124", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700132F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012862")]
			[Address(RVA = "0xDFA12C", Offset = "0xDFA12C", VA = "0xDFA12C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601285F")]
		[Address(RVA = "0xDF7A08", Offset = "0xDF7A08", VA = "0xDF7A08")]
		public _003COnPreprocessFinished_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012860")]
		[Address(RVA = "0xDF9ED8", Offset = "0xDF9ED8", VA = "0xDF9ED8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012863")]
		[Address(RVA = "0xDFA134", Offset = "0xDFA134", VA = "0xDFA134", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012864")]
		[Address(RVA = "0xDFA148", Offset = "0xDFA148", VA = "0xDFA148", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002C62")]
	private sealed class _003COnUpdate_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010ED1")]
		[FieldOffset(Offset = "0x8")]
		internal DisconnectedReason reason;

		[Token(Token = "0x6012865")]
		[Address(RVA = "0xDF829C", Offset = "0xDF829C", VA = "0xDF829C")]
		public _003COnUpdate_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6012866")]
		[Address(RVA = "0xDFA1D0", Offset = "0xDFA1D0", VA = "0xDFA1D0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010EC9")]
	[FieldOffset(Offset = "0x0")]
	private static ResourceID[] SCENE_RESOURCE_LIST;

	[Token(Token = "0x4010ECA")]
	[FieldOffset(Offset = "0x3C")]
	public PostEffectManager postEffect;

	[Token(Token = "0x4010ECB")]
	[FieldOffset(Offset = "0x40")]
	private bool m_SceneLoaded;

	[Token(Token = "0x4010ECC")]
	[FieldOffset(Offset = "0x44")]
	private uint mCSDrawPopupDelayCall;

	[Token(Token = "0x4010ECD")]
	[FieldOffset(Offset = "0x4")]
	private static List<Type> CacheTypesNeedsUnload;

	[Token(Token = "0x601283C")]
	[Address(RVA = "0xDF50B0", Offset = "0xDF50B0", VA = "0xDF50B0")]
	public FrontEndGame()
	{
	}

	[Token(Token = "0x601283D")]
	[Address(RVA = "0xDF50B8", Offset = "0xDF50B8", VA = "0xDF50B8", Slot = "18")]
	public override ResourceID[] GetResourceID()
	{
		return null;
	}

	[Token(Token = "0x601283E")]
	[Address(RVA = "0xDF5190", Offset = "0xDF5190", VA = "0xDF5190", Slot = "19")]
	public override Type GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x601283F")]
	[Address(RVA = "0xDF526C", Offset = "0xDF526C", VA = "0xDF526C", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6012840")]
	[Address(RVA = "0xDF6574", Offset = "0xDF6574", VA = "0xDF6574", Slot = "6")]
	public override bool NeedPreloadBeforeLoadScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6012841")]
	[Address(RVA = "0xDF60B4", Offset = "0xDF60B4", VA = "0xDF60B4")]
	private void OnReturnToLobbyFromInGame()
	{
	}

	[Token(Token = "0x6012842")]
	[Address(RVA = "0xDF65CC", Offset = "0xDF65CC", VA = "0xDF65CC")]
	public void CheckReconnectIfReachMaxResendCount()
	{
	}

	[Token(Token = "0x6012843")]
	[Address(RVA = "0xDF6EB0", Offset = "0xDF6EB0", VA = "0xDF6EB0")]
	private void OnLastGameNeedReconnectConfirm()
	{
	}

	[Token(Token = "0x6012844")]
	[Address(RVA = "0xDF73E8", Offset = "0xDF73E8", VA = "0xDF73E8")]
	private void OnLastGameNeedReconnectCancel()
	{
	}

	[Token(Token = "0x6012845")]
	[Address(RVA = "0xDF7774", Offset = "0xDF7774", VA = "0xDF7774", Slot = "20")]
	public override ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x6012846")]
	[Address(RVA = "0xDF78F8", Offset = "0xDF78F8", VA = "0xDF78F8", Slot = "26")]
	public override int GetGameType()
	{
		return default(int);
	}

	[Token(Token = "0x6012847")]
	[Address(RVA = "0xDF7950", Offset = "0xDF7950", VA = "0xDF7950", Slot = "7")]
	public override IEnumerator OnPreprocessFinished()
	{
		return null;
	}

	[Token(Token = "0x6012848")]
	[Address(RVA = "0xDF7A10", Offset = "0xDF7A10", VA = "0xDF7A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6012849")]
	[Address(RVA = "0xDF82A4", Offset = "0xDF82A4", VA = "0xDF82A4", Slot = "5")]
	public override void OnStartLoadScene()
	{
	}

	[Token(Token = "0x601284A")]
	[Address(RVA = "0xDF5E10", Offset = "0xDF5E10", VA = "0xDF5E10")]
	public void SetPostEffectProfile(bool isHD)
	{
	}

	[Token(Token = "0x601284B")]
	[Address(RVA = "0xDF8838", Offset = "0xDF8838", VA = "0xDF8838", Slot = "12")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x601284C")]
	[Address(RVA = "0xDF8314", Offset = "0xDF8314", VA = "0xDF8314")]
	private bool NeedUnloadCSVFromMemory()
	{
		return default(bool);
	}

	[Token(Token = "0x601284D")]
	[Address(RVA = "0xDF8998", Offset = "0xDF8998", VA = "0xDF8998")]
	private void UnloadCSVDataFromMemory()
	{
	}

	[Token(Token = "0x601284E")]
	[Address(RVA = "0xDF8528", Offset = "0xDF8528", VA = "0xDF8528")]
	private void ReloadCSVDataFromMemory()
	{
	}

	[Token(Token = "0x601284F")]
	[Address(RVA = "0xDF8CB4", Offset = "0xDF8CB4", VA = "0xDF8CB4")]
	public void ReloadTranslation(bool needOverride = false)
	{
	}

	[Token(Token = "0x6012850")]
	[Address(RVA = "0xDF9000", Offset = "0xDF9000", VA = "0xDF9000")]
	private int GetResourcePoolInitCount(ResourceID resID)
	{
		return default(int);
	}

	[Token(Token = "0x6012851")]
	[Address(RVA = "0xDF925C", Offset = "0xDF925C", VA = "0xDF925C")]
	private void PrePoolInstantRes()
	{
	}

	[Token(Token = "0x6012852")]
	[Address(RVA = "0xDF96C0", Offset = "0xDF96C0", VA = "0xDF96C0", Slot = "10")]
	protected override void OnPreloadLoaded()
	{
	}

	[Token(Token = "0x6012854")]
	[Address(RVA = "0xDF9B98", Offset = "0xDF9B98", VA = "0xDF9B98")]
	private void _003COnReturnToLobbyFromInGame_003Em__0()
	{
	}

	[Token(Token = "0x6012855")]
	[Address(RVA = "0xDF9CB8", Offset = "0xDF9CB8", VA = "0xDF9CB8")]
	private void _003COnLastGameNeedReconnectConfirm_003Em__1()
	{
	}

	[Token(Token = "0x6012856")]
	[Address(RVA = "0xDF9E90", Offset = "0xDF9E90", VA = "0xDF9E90")]
	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	[Token(Token = "0x6012857")]
	[Address(RVA = "0xDF9E98", Offset = "0xDF9E98", VA = "0xDF9E98")]
	public bool _003C_003EiFixBaseProxy_NeedPreloadBeforeLoadScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6012858")]
	[Address(RVA = "0xDF9EA0", Offset = "0xDF9EA0", VA = "0xDF9EA0")]
	public ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x6012859")]
	[Address(RVA = "0xDF9EA8", Offset = "0xDF9EA8", VA = "0xDF9EA8")]
	public int _003C_003EiFixBaseProxy_GetGameType()
	{
		return default(int);
	}

	[Token(Token = "0x601285A")]
	[Address(RVA = "0xDF9EB0", Offset = "0xDF9EB0", VA = "0xDF9EB0")]
	public IEnumerator _003C_003EiFixBaseProxy_OnPreprocessFinished()
	{
		return null;
	}

	[Token(Token = "0x601285B")]
	[Address(RVA = "0xDF9EB8", Offset = "0xDF9EB8", VA = "0xDF9EB8")]
	public void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	[Token(Token = "0x601285C")]
	[Address(RVA = "0xDF9EC0", Offset = "0xDF9EC0", VA = "0xDF9EC0")]
	public void _003C_003EiFixBaseProxy_OnStartLoadScene()
	{
	}

	[Token(Token = "0x601285D")]
	[Address(RVA = "0xDF9EC8", Offset = "0xDF9EC8", VA = "0xDF9EC8")]
	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x601285E")]
	[Address(RVA = "0xDF9ED0", Offset = "0xDF9ED0", VA = "0xDF9ED0")]
	public void _003C_003EiFixBaseProxy_OnPreloadLoaded()
	{
	}
}
