import { ReactNode } from "react";

type Props = {
    children: ReactNode,
    color?: string,
}

const CompWithChildren = (props: Props) => {
    return (
        <div>
            <h2 style={{ color: props?.color ?? "green" }}>ala ma kota</h2>
            {props.children}
        </div>
    )
}

export default CompWithChildren