using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A96")]
public class SwitchSceneManager : MonoBehaviour
{
	[Token(Token = "0x2000A97")]
	private sealed class _003CUnloadScene_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005CE4")]
		[FieldOffset(Offset = "0x8")]
		internal AsyncOperation _003Cop_003E__0;

		[Token(Token = "0x4005CE5")]
		[FieldOffset(Offset = "0xC")]
		internal SwitchSceneManager _0024this;

		[Token(Token = "0x4005CE6")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4005CE7")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4005CE8")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000640")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005141")]
			[Address(RVA = "0x21DC6DC", Offset = "0x21DC6DC", VA = "0x21DC6DC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000641")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005142")]
			[Address(RVA = "0x21DC6E4", Offset = "0x21DC6E4", VA = "0x21DC6E4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600513F")]
		[Address(RVA = "0x21DBBB0", Offset = "0x21DBBB0", VA = "0x21DBBB0")]
		public _003CUnloadScene_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6005140")]
		[Address(RVA = "0x21DC4D4", Offset = "0x21DC4D4", VA = "0x21DC4D4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005143")]
		[Address(RVA = "0x21DC6EC", Offset = "0x21DC6EC", VA = "0x21DC6EC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005144")]
		[Address(RVA = "0x21DC700", Offset = "0x21DC700", VA = "0x21DC700", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000A98")]
	private sealed class _003CLoadScene_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005CE9")]
		[FieldOffset(Offset = "0x8")]
		internal AsyncOperation _003Cop_003E__0;

		[Token(Token = "0x4005CEA")]
		[FieldOffset(Offset = "0xC")]
		internal SwitchSceneManager _0024this;

		[Token(Token = "0x4005CEB")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4005CEC")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4005CED")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000642")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005147")]
			[Address(RVA = "0x21DC428", Offset = "0x21DC428", VA = "0x21DC428", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000643")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005148")]
			[Address(RVA = "0x21DC430", Offset = "0x21DC430", VA = "0x21DC430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005145")]
		[Address(RVA = "0x21DBC40", Offset = "0x21DBC40", VA = "0x21DBC40")]
		public _003CLoadScene_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6005146")]
		[Address(RVA = "0x21DC154", Offset = "0x21DC154", VA = "0x21DC154", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005149")]
		[Address(RVA = "0x21DC438", Offset = "0x21DC438", VA = "0x21DC438", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600514A")]
		[Address(RVA = "0x21DC44C", Offset = "0x21DC44C", VA = "0x21DC44C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005CDE")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID m_CurActivedScene;

	[Token(Token = "0x4005CDF")]
	[FieldOffset(Offset = "0x10")]
	private ResourceID m_PendingLoadScene;

	[Token(Token = "0x4005CE0")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsSwitching;

	[Token(Token = "0x4005CE1")]
	[FieldOffset(Offset = "0x18")]
	public float DelayLoadTime;

	[Token(Token = "0x4005CE2")]
	[FieldOffset(Offset = "0x1C")]
	private int m_NeedActiveSceneIndex;

	[Token(Token = "0x4005CE3")]
	[FieldOffset(Offset = "0x20")]
	private Action m_OnSwitchFinisedCall;

	[Token(Token = "0x1700063F")]
	public bool IsSwitching
	{
		[Token(Token = "0x6005134")]
		[Address(RVA = "0x21DB808", Offset = "0x21DB808", VA = "0x21DB808")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005133")]
	[Address(RVA = "0x21DB75C", Offset = "0x21DB75C", VA = "0x21DB75C")]
	public SwitchSceneManager()
	{
	}

	[Token(Token = "0x6005135")]
	[Address(RVA = "0x21DB810", Offset = "0x21DB810", VA = "0x21DB810")]
	private void Start()
	{
	}

	[Token(Token = "0x6005136")]
	[Address(RVA = "0x21DB97C", Offset = "0x21DB97C", VA = "0x21DB97C")]
	public void RegisterLoadCallBack(Action onSwitchFinised)
	{
	}

	[Token(Token = "0x6005137")]
	[Address(RVA = "0x21DB984", Offset = "0x21DB984", VA = "0x21DB984")]
	public void SwitchScene(ResourceID targetSceneResID, int needActiveSceneIndex)
	{
	}

	[Token(Token = "0x6005138")]
	[Address(RVA = "0x21DBB08", Offset = "0x21DBB08", VA = "0x21DBB08")]
	private IEnumerator UnloadScene()
	{
		return null;
	}

	[Token(Token = "0x6005139")]
	[Address(RVA = "0x21DBB8C", Offset = "0x21DBB8C", VA = "0x21DBB8C")]
	private void OnUnloadFinished()
	{
	}

	[Token(Token = "0x600513A")]
	[Address(RVA = "0x21DBBBC", Offset = "0x21DBBBC", VA = "0x21DBBBC")]
	private IEnumerator LoadScene()
	{
		return null;
	}

	[Token(Token = "0x600513B")]
	[Address(RVA = "0x21DBC48", Offset = "0x21DBC48", VA = "0x21DBC48")]
	public void UnloadSingleBountyRes()
	{
	}

	[Token(Token = "0x600513C")]
	[Address(RVA = "0x21DBBB8", Offset = "0x21DBBB8", VA = "0x21DBBB8")]
	private void PreSwitchScene()
	{
	}

	[Token(Token = "0x600513D")]
	[Address(RVA = "0x21DBD28", Offset = "0x21DBD28", VA = "0x21DBD28")]
	private void OnSceneLoadFinish()
	{
	}

	[Token(Token = "0x600513E")]
	[Address(RVA = "0x21DBD64", Offset = "0x21DBD64", VA = "0x21DBD64")]
	public void OverrideLighting(int index = -1)
	{
	}
}
