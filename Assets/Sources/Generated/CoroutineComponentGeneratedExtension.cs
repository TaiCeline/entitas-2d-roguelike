//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public CoroutineComponent coroutine { get { return (CoroutineComponent)GetComponent(ComponentIds.Coroutine); } }

        public bool hasCoroutine { get { return HasComponent(ComponentIds.Coroutine); } }

        public Entity AddCoroutine(System.Collections.IEnumerator newValue) {
            var component = CreateComponent<CoroutineComponent>(ComponentIds.Coroutine);
            component.value = newValue;
            return AddComponent(ComponentIds.Coroutine, component);
        }

        public Entity ReplaceCoroutine(System.Collections.IEnumerator newValue) {
            var component = CreateComponent<CoroutineComponent>(ComponentIds.Coroutine);
            component.value = newValue;
            ReplaceComponent(ComponentIds.Coroutine, component);
            return this;
        }

        public Entity RemoveCoroutine() {
            return RemoveComponent(ComponentIds.Coroutine);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherCoroutine;

        public static IMatcher Coroutine {
            get {
                if (_matcherCoroutine == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Coroutine);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherCoroutine = matcher;
                }

                return _matcherCoroutine;
            }
        }
    }
}
