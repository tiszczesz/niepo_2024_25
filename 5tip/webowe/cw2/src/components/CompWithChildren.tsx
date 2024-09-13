import { ReactNode } from "react";

type Props = {
    children: ReactNode,
    color?: string,
    header:string
}

const CompWithChildren = (props: Props) => {
    return (
        <div>
            <h2 style={{ color: props?.color ?? "green" }}>{props.header}</h2>
            {props.children}
        </div>
    )
}

export default CompWithChildren