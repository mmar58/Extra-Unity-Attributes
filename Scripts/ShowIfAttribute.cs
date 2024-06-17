namespace MMAR.Attributes {
    using UnityEngine;

    public class ShowIfAttribute : PropertyAttribute {
        public string ConditionalFieldName;

        public ShowIfAttribute(string conditionalFieldName) {
            ConditionalFieldName = conditionalFieldName;
        }
    }

}
