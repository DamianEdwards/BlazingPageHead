// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function processHeadContent(contentElement, suffix) {
    let newContent = contentElement.childNodes;
    var title;
    newContent.forEach(n => {
        if (n.nodeType === 1) { // Element node
            n.setAttribute("data-phm", "true");
            if (n.nodeName === "TITLE") {
                title = `${n.textContent}${suffix}`;
                document.title = title;
            } else {
                document.head.appendChild(n);
            }
        }
    });
    if (title) {
        return title;
    }
}

export function resetHead(title) {
    let els = document.head.querySelectorAll("*[data-phm]");
    els.forEach(e => e.remove());
    document.title = title;
}
